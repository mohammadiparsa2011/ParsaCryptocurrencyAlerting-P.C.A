namespace AlarmCryptoParsa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tblcurrencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cryptocurrencyDataSet = new AlarmCryptoParsa.cryptocurrencyDataSet();
            this.tblcurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_currencyTableAdapter = new AlarmCryptoParsa.cryptocurrencyDataSetTableAdapters.Tbl_currencyTableAdapter();
            this.timerUpdateDatabase = new System.Windows.Forms.Timer(this.components);
            this.timerTimeDisconect = new System.Windows.Forms.Timer(this.components);
            this.timerTimeplayer = new System.Windows.Forms.Timer(this.components);
            this.timerMoreOrLess = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lblShowMoreLess = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaySound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeUpdatePrice = new System.Windows.Forms.TextBox();
            this.txtTimePlayAlarm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStopSound = new System.Windows.Forms.Button();
            this.lblTimeDisconect = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartStopAlarm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblsave = new System.Windows.Forms.Label();
            this.btnsaveDatabase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeCurrencyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priceNowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmMoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmLessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblcurrencyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptocurrencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcurrencyBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblcurrencyBindingSource1
            // 
            this.tblcurrencyBindingSource1.DataMember = "Tbl_currency";
            this.tblcurrencyBindingSource1.DataSource = this.cryptocurrencyDataSet;
            // 
            // cryptocurrencyDataSet
            // 
            this.cryptocurrencyDataSet.DataSetName = "cryptocurrencyDataSet";
            this.cryptocurrencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcurrencyBindingSource
            // 
            this.tblcurrencyBindingSource.DataMember = "Tbl_currency";
            this.tblcurrencyBindingSource.DataSource = this.cryptocurrencyDataSet;
            // 
            // tbl_currencyTableAdapter
            // 
            this.tbl_currencyTableAdapter.ClearBeforeFill = true;
            // 
            // timerUpdateDatabase
            // 
            this.timerUpdateDatabase.Interval = 1000;
            this.timerUpdateDatabase.Tick += new System.EventHandler(this.timerUpdateDatabase_Tick);
            // 
            // timerTimeDisconect
            // 
            this.timerTimeDisconect.Interval = 1000;
            this.timerTimeDisconect.Tick += new System.EventHandler(this.timerTimeDisconect_Tick);
            // 
            // timerTimeplayer
            // 
            this.timerTimeplayer.Interval = 1000;
            this.timerTimeplayer.Tick += new System.EventHandler(this.timerTimeplayer_Tick);
            // 
            // timerMoreOrLess
            // 
            this.timerMoreOrLess.Interval = 1000;
            this.timerMoreOrLess.Tick += new System.EventHandler(this.timerMoreOrLess_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1077, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "درباره اثر";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1077, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lblShowMoreLess);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1077, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "هشدار ارز دیجیتال";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(482, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "نام ارزها برای بررسی :";
            // 
            // lblShowMoreLess
            // 
            this.lblShowMoreLess.AutoSize = true;
            this.lblShowMoreLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowMoreLess.ForeColor = System.Drawing.Color.Coral;
            this.lblShowMoreLess.Location = new System.Drawing.Point(479, 287);
            this.lblShowMoreLess.Name = "lblShowMoreLess";
            this.lblShowMoreLess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblShowMoreLess.Size = new System.Drawing.Size(0, 17);
            this.lblShowMoreLess.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtPlaySound);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTimeUpdatePrice);
            this.groupBox3.Controls.Add(this.txtTimePlayAlarm);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(0, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 143);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تنظیمات برنامه";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Controls.Add(this.radioButton5);
            this.groupBox5.Location = new System.Drawing.Point(14, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(119, 80);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "آهنگ هشدار";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "آهنگ 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(26, 63);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 17);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.Text = "آهنگ 3";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(26, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(56, 17);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "آهنگ 1";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Location = new System.Drawing.Point(14, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 59);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "پس زمینه";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "روشن";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(36, 36);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "ملایم";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "زمان پخش صدای هشدار :";
            // 
            // txtPlaySound
            // 
            this.txtPlaySound.Location = new System.Drawing.Point(185, 65);
            this.txtPlaySound.Name = "txtPlaySound";
            this.txtPlaySound.Size = new System.Drawing.Size(41, 20);
            this.txtPlaySound.TabIndex = 7;
            this.txtPlaySound.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "مدت زمان بروزرسانی قیمت ها (ثانیه) :";
            // 
            // txtTimeUpdatePrice
            // 
            this.txtTimeUpdatePrice.Location = new System.Drawing.Point(185, 98);
            this.txtTimeUpdatePrice.Name = "txtTimeUpdatePrice";
            this.txtTimeUpdatePrice.Size = new System.Drawing.Size(42, 20);
            this.txtTimeUpdatePrice.TabIndex = 2;
            this.txtTimeUpdatePrice.Text = "2";
            // 
            // txtTimePlayAlarm
            // 
            this.txtTimePlayAlarm.Location = new System.Drawing.Point(185, 27);
            this.txtTimePlayAlarm.Name = "txtTimePlayAlarm";
            this.txtTimePlayAlarm.Size = new System.Drawing.Size(42, 20);
            this.txtTimePlayAlarm.TabIndex = 1;
            this.txtTimePlayAlarm.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "مدت زمان قطع اتصال برای شروع آلارم (ثانیه) :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStopSound);
            this.groupBox2.Controls.Add(this.lblTimeDisconect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnStartStopAlarm);
            this.groupBox2.Location = new System.Drawing.Point(462, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 153);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "شروع و توقف هشدار";
            // 
            // btnStopSound
            // 
            this.btnStopSound.Location = new System.Drawing.Point(98, 110);
            this.btnStopSound.Name = "btnStopSound";
            this.btnStopSound.Size = new System.Drawing.Size(116, 33);
            this.btnStopSound.TabIndex = 3;
            this.btnStopSound.Text = "توقف پخش صدا";
            this.btnStopSound.UseVisualStyleBackColor = true;
            this.btnStopSound.Click += new System.EventHandler(this.btnStopSound_Click);
            // 
            // lblTimeDisconect
            // 
            this.lblTimeDisconect.AutoSize = true;
            this.lblTimeDisconect.Location = new System.Drawing.Point(35, 81);
            this.lblTimeDisconect.Name = "lblTimeDisconect";
            this.lblTimeDisconect.Size = new System.Drawing.Size(13, 13);
            this.lblTimeDisconect.TabIndex = 2;
            this.lblTimeDisconect.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "مدت زمان قطع اتصال (ثانیه) :";
            // 
            // btnStartStopAlarm
            // 
            this.btnStartStopAlarm.BackColor = System.Drawing.Color.LightCoral;
            this.btnStartStopAlarm.Enabled = false;
            this.btnStartStopAlarm.Location = new System.Drawing.Point(83, 28);
            this.btnStartStopAlarm.Name = "btnStartStopAlarm";
            this.btnStartStopAlarm.Size = new System.Drawing.Size(148, 23);
            this.btnStartStopAlarm.TabIndex = 0;
            this.btnStartStopAlarm.Text = "هشدار خاموش است";
            this.btnStartStopAlarm.UseVisualStyleBackColor = false;
            this.btnStartStopAlarm.Click += new System.EventHandler(this.btnStartStopAlarm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.lblsave);
            this.groupBox1.Controls.Add(this.btnsaveDatabase);
            this.groupBox1.Location = new System.Drawing.Point(716, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "شروع و توقف اجرای برنامه";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(93, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(204, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "توقف";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblsave
            // 
            this.lblsave.AutoSize = true;
            this.lblsave.BackColor = System.Drawing.Color.LightCoral;
            this.lblsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblsave.Location = new System.Drawing.Point(192, 106);
            this.lblsave.Name = "lblsave";
            this.lblsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblsave.Size = new System.Drawing.Size(166, 20);
            this.lblsave.TabIndex = 5;
            this.lblsave.Text = "نرم افزار خاموش می باشد";
            this.lblsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsaveDatabase
            // 
            this.btnsaveDatabase.Location = new System.Drawing.Point(93, 62);
            this.btnsaveDatabase.Name = "btnsaveDatabase";
            this.btnsaveDatabase.Size = new System.Drawing.Size(210, 23);
            this.btnsaveDatabase.TabIndex = 4;
            this.btnsaveDatabase.Text = "ثبت تغییرات در بانک اطلاعاتی - شروع";
            this.btnsaveDatabase.UseVisualStyleBackColor = true;
            this.btnsaveDatabase.Click += new System.EventHandler(this.btnsaveDatabase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameCurrencyDataGridViewTextBoxColumn,
            this.activeCurrencyDataGridViewCheckBoxColumn,
            this.priceNowDataGridViewTextBoxColumn,
            this.alarmMoreDataGridViewTextBoxColumn,
            this.alarmLessDataGridViewTextBoxColumn,
            this.contractCurrencyDataGridViewTextBoxColumn,
            this.comment1DataGridViewTextBoxColumn,
            this.comment2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblcurrencyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1081, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "شناسه";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameCurrencyDataGridViewTextBoxColumn
            // 
            this.nameCurrencyDataGridViewTextBoxColumn.DataPropertyName = "NameCurrency";
            this.nameCurrencyDataGridViewTextBoxColumn.HeaderText = "نام ارز";
            this.nameCurrencyDataGridViewTextBoxColumn.Name = "nameCurrencyDataGridViewTextBoxColumn";
            this.nameCurrencyDataGridViewTextBoxColumn.Width = 120;
            // 
            // activeCurrencyDataGridViewCheckBoxColumn
            // 
            this.activeCurrencyDataGridViewCheckBoxColumn.DataPropertyName = "ActiveCurrency";
            this.activeCurrencyDataGridViewCheckBoxColumn.HeaderText = "فعال بودن هشدار";
            this.activeCurrencyDataGridViewCheckBoxColumn.Name = "activeCurrencyDataGridViewCheckBoxColumn";
            // 
            // priceNowDataGridViewTextBoxColumn
            // 
            this.priceNowDataGridViewTextBoxColumn.DataPropertyName = "PriceNow";
            this.priceNowDataGridViewTextBoxColumn.HeaderText = "قیمت الان";
            this.priceNowDataGridViewTextBoxColumn.Name = "priceNowDataGridViewTextBoxColumn";
            this.priceNowDataGridViewTextBoxColumn.Width = 150;
            // 
            // alarmMoreDataGridViewTextBoxColumn
            // 
            this.alarmMoreDataGridViewTextBoxColumn.DataPropertyName = "AlarmMore";
            this.alarmMoreDataGridViewTextBoxColumn.HeaderText = "هشدار سقف قیمت";
            this.alarmMoreDataGridViewTextBoxColumn.Name = "alarmMoreDataGridViewTextBoxColumn";
            this.alarmMoreDataGridViewTextBoxColumn.Width = 150;
            // 
            // alarmLessDataGridViewTextBoxColumn
            // 
            this.alarmLessDataGridViewTextBoxColumn.DataPropertyName = "AlarmLess";
            this.alarmLessDataGridViewTextBoxColumn.HeaderText = "هشدار کف قیمت";
            this.alarmLessDataGridViewTextBoxColumn.Name = "alarmLessDataGridViewTextBoxColumn";
            this.alarmLessDataGridViewTextBoxColumn.Width = 150;
            // 
            // contractCurrencyDataGridViewTextBoxColumn
            // 
            this.contractCurrencyDataGridViewTextBoxColumn.DataPropertyName = "ContractCurrency";
            this.contractCurrencyDataGridViewTextBoxColumn.HeaderText = "آدرس کانترکت";
            this.contractCurrencyDataGridViewTextBoxColumn.Name = "contractCurrencyDataGridViewTextBoxColumn";
            // 
            // comment1DataGridViewTextBoxColumn
            // 
            this.comment1DataGridViewTextBoxColumn.DataPropertyName = "Comment1";
            this.comment1DataGridViewTextBoxColumn.HeaderText = "توضیحات 1";
            this.comment1DataGridViewTextBoxColumn.Name = "comment1DataGridViewTextBoxColumn";
            this.comment1DataGridViewTextBoxColumn.Width = 110;
            // 
            // comment2DataGridViewTextBoxColumn
            // 
            this.comment2DataGridViewTextBoxColumn.DataPropertyName = "Comment2";
            this.comment2DataGridViewTextBoxColumn.HeaderText = "توضیحات 2";
            this.comment2DataGridViewTextBoxColumn.Name = "comment2DataGridViewTextBoxColumn";
            this.comment2DataGridViewTextBoxColumn.Width = 110;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1085, 491);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1077, 465);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "درباره نرم افزار";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(424, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(626, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Github : https://github.com/parsamohammadi9831/ParsaCryptocurrencyAlerting P.C.A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(424, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date: 2024-01-01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(424, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Version: 1.2.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(179)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(424, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ParsaCryptocurrencyAlerting ( P.C.A )";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 377);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 506);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParsaCryptocurrencyAlerting ( P.C.A )";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblcurrencyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptocurrencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcurrencyBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private cryptocurrencyDataSet cryptocurrencyDataSet;
        private System.Windows.Forms.BindingSource tblcurrencyBindingSource;
        private cryptocurrencyDataSetTableAdapters.Tbl_currencyTableAdapter tbl_currencyTableAdapter;
        private System.Windows.Forms.Timer timerUpdateDatabase;
        private System.Windows.Forms.BindingSource tblcurrencyBindingSource1;
        private System.Windows.Forms.Timer timerTimeDisconect;
        private System.Windows.Forms.Timer timerTimeplayer;
        private System.Windows.Forms.Timer timerMoreOrLess;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblShowMoreLess;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaySound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeUpdatePrice;
        private System.Windows.Forms.TextBox txtTimePlayAlarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStopSound;
        private System.Windows.Forms.Label lblTimeDisconect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartStopAlarm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblsave;
        private System.Windows.Forms.Button btnsaveDatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeCurrencyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceNowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmMoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmLessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment2DataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
    }
}

