using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Threading;
using System.Media;

namespace AlarmCryptoParsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region محل تعریف متغییر های عمومی

        bool statusStartStopAlarm ;
        string nameFileJson ;
        SoundPlayer player,playerMoreLess;     // نام فایل هشدار
        bool statusePalyer;  //یعنی هشدار فعلا پخش نشود

        bool statusPlayMoreLess;
        int countMoreLess;
        int countPlayMoreLess ;

        // تعریف آرایه ها از فیلد های دیتابیس
        string[] nameCurrency;
        bool[] activeCurrency;
        double[] priceNow;
        double[] alarmMore;
        double[] alarmLess;
        string[] contractCurrency;
        double[] priceLast;
        string[] comment2;

        // پایان تعریف آرایه ها از فیلد های دیتابیس

        #endregion
        
        #region محل تعریف توابعی که خودمان تعریف کرده ایم و فرم لود برنامه

        // پر کردن آرایه ها از روی دیتاهای دیتاگرید
        private void fillArrayOfDatagrid()
        {
            try
            {
                // ساخت تعداد عناصر آرایه از روی تعداد سطر های دیتاگرید
                int rowCountDatagrid = dataGridView1.RowCount;
                nameCurrency = new string[rowCountDatagrid];
                activeCurrency = new bool[rowCountDatagrid];
                priceNow = new double[rowCountDatagrid];
                alarmMore = new double[rowCountDatagrid];
                alarmLess = new double[rowCountDatagrid];



                for (int i = 0; i < rowCountDatagrid; i++)
                {

                    nameCurrency[i] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    activeCurrency[i] = bool.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    priceNow[i] = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                    alarmMore[i] = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    alarmLess[i] = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                }

            }
            catch (Exception)
            {
               
            }
           


        }

        // تابع تنظیمات اولیه متغییرها و کنترلهای برنامه
        private void InitialSettings() 
        {
            timerUpdateDatabase.Interval = 1000;
            timerTimeplayer.Interval = 1000;
            timerTimeDisconect.Interval = 1000;

            player = new SoundPlayer(Properties.Resources.ring3);
            playerMoreLess = new SoundPlayer(Properties.Resources.ring2);

            // تنظیمات اولیه موقعیت دیتا گرید
            dataGridView1.Left = tabControl1.Left = 0;
            dataGridView1.Top = tabControl1.Top = 0;
            dataGridView1.Width = tabControl1.Width = this.Width;
            tabControl1.Height = this.Height;
            dataGridView1.Height = (int)(tabControl1.Height / 1.5);


            // تنظیملت اولیه دکمه هشدار
            btnStartStopAlarm.BackColor = Color.Red;
            btnStartStopAlarm.ForeColor = Color.Gold;
            statusStartStopAlarm = false;

            statusStartStopAlarm = false;
            nameFileJson = "pricecurency.json";
             
            statusePalyer = false; //یعنی هشدار فعلا پخش نشود

           statusPlayMoreLess = false;
           countMoreLess = 0;
           countPlayMoreLess = 0;
        }

        // فرم لود برنامه 
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // اتصال به جدول دیتابیس
                this.tbl_currencyTableAdapter.Fill(this.cryptocurrencyDataSet.Tbl_currency);
                // پر کردن آرایه ها از روی دیتاهای دیتاگرید
                fillArrayOfDatagrid();
            }
            catch (Exception)
            {
            }

            //تابع برای تنظیمات اولیه متغییرها و کنترل ها
            InitialSettings();

        }
        #endregion
        
        #region   محل کدهای تمام تایمرهای برنامه

        // تایمر آپدیت می کند دیتا بیس  و چک می کند فایل جیسون ساخته شده است یا نه
        private void timerUpdateDatabase_Tick(object sender, EventArgs e)
        {
            try
            {
                this.tbl_currencyTableAdapter.Fill(this.cryptocurrencyDataSet.Tbl_currency);
            }
            catch (Exception)
            {
            }

            try
            {
                // اگر فایل جیسون وجود داشت یعنی دیتا تولید می شود
                if (File.Exists(nameFileJson))
                {
                    File.Delete(nameFileJson);
                    lblTimeDisconect.Text = "0";
                    
                    timerTimeplayer.Enabled = false; //تایمر قطع بودن اتصال کار نکند
                    timerTimeDisconect.Enabled = false;

                    statusePalyer = false; // یعنی هشدار پخش نشود
                    player.Stop();
                }
                else if (timerTimeDisconect.Enabled == false)
                {
                    statusePalyer = true;
                    timerTimeplayer.Enabled = true; // یعنی تایمر قطع بودن اتصال کار کند
                    timerTimeDisconect.Enabled = true;
                }

                timerUpdateDatabase.Interval = int.Parse(txtTimeUpdatePrice.Text) * 1000;
                timerTimeplayer.Interval = 1000;
            }
            catch (Exception)
            {                
            }          
        }

        // تایمر زمان پخش صدای هشدار
        private void timerTimeplayer_Tick(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(lblTimeDisconect.Text);
                lblTimeDisconect.Text = x.ToString();

                // اگر اتصال اینترنتی قطع شد و یا فایل جیسون ساخته نشد و زمان قطع اتصال بیشتر از تایم داده شده شد هشدار دهد
                if (x > int.Parse(txtTimePlayAlarm.Text) && (x < int.Parse(txtTimePlayAlarm.Text) + int.Parse(txtPlaySound.Text)) && statusePalyer == true)
                {
                    player.Stop();
                    playerMoreLess.Stop();
                    player.PlayLooping();
                    statusePalyer = false;
                }

                // اگر زمان بخش صدای هشدار تمام شد هشدار متوقف میشود
                if (x >= int.Parse(txtTimePlayAlarm.Text) + int.Parse(txtPlaySound.Text))
                {
                    statusePalyer = true;
                    player.Stop();
                }
            }
            catch (Exception)
            {    
            }            
        }
      
        // تایمر برای شمردن قطع بودن یا آپدیت نشدن دیتا بیس بر حسب ثانیه
        private void timerTimeDisconect_Tick(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(lblTimeDisconect.Text);
                x++;
                lblTimeDisconect.Text = x.ToString();
            }
            catch (Exception)
            {               
            }          
        }

        // تایمر هشدار برای بیشتر یا کمتر شدن قیمت
        private void timerMoreOrLess_Tick(object sender, EventArgs e)
        {
            int rowCountDatagrid = dataGridView1.RowCount;

            countPlayMoreLess++;
            string nameCryptomoreLess = "";

            for (int i = 0; i < rowCountDatagrid; i++)
            {
                if (priceNow[i] != 0 && (alarmMore[i] != 0 || alarmLess[i] != 0) &&
                    (priceNow[i] >= alarmMore[i] || priceNow[i] <= alarmLess[i]) &&
                    activeCurrency[i] && statusPlayMoreLess == false)
                {
                    countMoreLess++;
                    nameCryptomoreLess += nameCurrency[i] + " , ";
                }
            }

            if (countMoreLess > 0)
            {
                lblShowMoreLess.Text = nameCryptomoreLess;
                statusPlayMoreLess = true;
                player.Stop();
                playerMoreLess.Stop();

                playerMoreLess.PlayLooping();
                Thread.Sleep(3000);

                countMoreLess = 0;
            }

            if (countPlayMoreLess >= int.Parse(txtPlaySound.Text))
            {
                playerMoreLess.Stop();
                countPlayMoreLess = 0;

                btnStartStopAlarm.Text = "هشدار خاموش است";
                btnStartStopAlarm.BackColor = Color.Red;
                btnStartStopAlarm.ForeColor = Color.Gold;
                statusStartStopAlarm = false;
                timerMoreOrLess.Enabled = false;  // خاموش کردن بررسی ارزها و اعلام هشدار بیشتر یا کمتر
            }
        }

        #endregion
             
        #region  محل کدهای مربوط به دکمه ها
        // دکمه ی توقف اجرای نرم افزار
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                timerUpdateDatabase.Enabled = false;
                timerTimeDisconect.Enabled = false;
                timerTimeplayer.Enabled = false;
                btnsaveDatabase.Enabled = true;
                btnStop.Enabled = false;
                dataGridView1.Enabled = true;
                lblsave.Text = "";
                lblTimeDisconect.Text = "0";
                player.Stop();

                btnStartStopAlarm.Text = "هشدار خاموش است";
                btnStartStopAlarm.BackColor = Color.Red;
                btnStartStopAlarm.ForeColor = Color.Gold;
                btnStartStopAlarm.Enabled = false;

                lblsave.Text = "نرم افزار خاموش می باشد";
                lblsave.BackColor = Color.LightCoral;
            }
            catch (Exception)
            {           
            }           
        }

        // دکمه ی ثبت تغییرات دیتا گرید در دیتابیس و اجرای نرم افزار
        private void btnsaveDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_currencyTableAdapter.Update(this.cryptocurrencyDataSet.Tbl_currency);                
                dataGridView1.Refresh();
                fillArrayOfDatagrid();

                btnsaveDatabase.Enabled = false;
                btnStop.Enabled = true;
                dataGridView1.Enabled = false;
                                
                lblsave.BackColor = Color.Green;
                lblsave.ForeColor = Color.Gold;
                lblsave.Text = "ثبت شد - نرم افزار در حال اجرا";
                lblsave.Left = (int)(groupBox1.Width /1.4 - lblsave.Width / 2);
                btnStartStopAlarm.Enabled = true;

                timerUpdateDatabase.Enabled = true;
                timerUpdateDatabase.Interval = 1000;
            }
            catch (Exception)
            {
                this.tbl_currencyTableAdapter.Fill(this.cryptocurrencyDataSet.Tbl_currency);
                dataGridView1.Refresh();

                lblsave.BackColor = Color.Red;
                lblsave.ForeColor = Color.Gold;
                lblsave.Text = " ثبت نشد - نرم افزار فعال نیست - لطفا دوباره کلیک نمایید";
                lblsave.Left = (int)(groupBox1.Width / 1.4 - lblsave.Width / 2);
            }
        }

        // توقف صدای آهنگ
        private void btnStopSound_Click(object sender, EventArgs e)
        {
            player.Stop();
            playerMoreLess.Stop();
        }

        // دکمه ی شروع و توقف هشدار
        private void btnStartStopAlarm_Click(object sender, EventArgs e)
        {
            try
            {
                // کد های مربوط به روشن شدن هشدار
                if (statusStartStopAlarm == false)
                {
                    btnStartStopAlarm.Text = "هشدار روشن است";
                    btnStartStopAlarm.BackColor = Color.Green;
                    btnStartStopAlarm.ForeColor = Color.Gold;
                    statusStartStopAlarm = true;

                    countMoreLess = 0;
                    countPlayMoreLess = 0;
                    statusPlayMoreLess = false;
                    lblShowMoreLess.Text = "";

                    timerMoreOrLess.Enabled = true;  // برای بررسی ارزها و اعلام هشدار بیشتر یا کمتر
                }
                else
                {
                    btnStartStopAlarm.Text = "هشدار خاموش است";
                    btnStartStopAlarm.BackColor = Color.Red;
                    btnStartStopAlarm.ForeColor = Color.Gold;
                    statusStartStopAlarm = false;
                    timerMoreOrLess.Enabled = false;  // خاموش کردن بررسی ارزها و اعلام هشدار بیشتر یا کمتر
                }
            }
            catch (Exception)
            {                
            }          
        }
        #endregion

        #region این دو رادیو باتن برای انتخاب پس زمینه میباشد

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            tabPage1.BackColor = Color.White;
            tabPage2.BackColor = Color.White;
            tabPage3.BackColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Lavender;
            tabPage1.BackColor = Color.Lavender;
            tabPage2.BackColor = Color.Lavender;
            tabPage3.BackColor = Color.Lavender;
            dataGridView1.BackgroundColor = Color.Lavender;
        }
        #endregion

        #region این سه رادیو باتن برای انتخاب آهنگ هشدار میباشند

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.ring3);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.ring2);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.ring4);
        }
        #endregion

        
    }     
}
