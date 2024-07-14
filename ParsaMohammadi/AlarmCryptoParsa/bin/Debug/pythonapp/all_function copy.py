
import pyodbc                           # این کتابخانه برای اتصال به دیتابیس استفاده میشود




path_db_conection='Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=' + name_file_database + ';'



# یک رشته از نام ارزهایی که در دیتابیس فعال میباشند را برمیگرداند
def make_string_api():       
    conn = pyodbc.connect(rf'{path_db_conection}')   
    cursor = conn.cursor()
    cursor.execute('UPDATE Tbl_currency SET PriceNow=0')        # فیلد قیمت الان را در دیتابیس صفر میکند تا آماده شود برای قیمت جدید
    conn.commit()
    cursor.execute('select * from Tbl_currency')
    
    ids = ""
    for row in cursor.fetchall():          
        name_crypto = row[1]                # نام ارز
        active_crypto = row[2]              # فعال بودن ارز را مشخص می کند
        if active_crypto : 
            ids += name_crypto + ","        # بین نام ارزهای انتخاب شده در دیتابیس یک کاما قرار میدهد
    conn.close()
    return ids

# این تابع برای بروزرسانی قیمت فعلی ارز در دیتابیس اکسس میباشد
def update_price_database(msg):
    name_coin_list = list()
    price_coin_list = list()
    msg_list = str(msg).split(",")
    for x in msg_list:          # نام ارز و قیمت آن را به شکل خالص در دو لیست قرار میدهد به عبارت دیگر تمام کارکترهای اضافه را حذف میکند
         name_coin_list.append(x.split(':')[0].replace("{","").replace("'","").replace(" ","")) 
         price_coin_list.append(x.split(':')[1].replace("}","").replace(" ",""))
         
  
    conn=pyodbc.connect(rf'{path_db_conection}',autocommit=True)
    cursor=conn.cursor()
    
    
    i=0
    while(i < len(name_coin_list)):         # فیلد ،قیمت ارزهایی که انتخاب شده است را در دیتابیس بروزرسانی میکند
        cursor.execute('UPDATE Tbl_currency SET [PriceNow]=? where NameCurrency=?', price_coin_list[i], name_coin_list[i])
        conn.commit()
        i += 1

    print("\n------------    update database  ---------------\n")
    time.sleep(1)
    os.system( 'cls' )      # صفحه ی نمایش را پاک میکند
    conn.close()