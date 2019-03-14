namespace AliSoft
{
    partial class satis
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
            this.textBarkod_No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textMusteriID = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMusteri_adi = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelParaUstu = new System.Windows.Forms.Label();
            this.txtAlinanUcret = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonDegisim = new System.Windows.Forms.Button();
            this.buttonUrunEklebtn = new System.Windows.Forms.Button();
            this.labelAdetokutuldu = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelKKturu = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degisecekurunfiyati = new System.Windows.Forms.Label();
            this.groupBoxdegisim = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.odenecektutar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxdegisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBarkod_No
            // 
            this.textBarkod_No.Location = new System.Drawing.Point(21, 189);
            this.textBarkod_No.Name = "textBarkod_No";
            this.textBarkod_No.Size = new System.Drawing.Size(211, 20);
            this.textBarkod_No.TabIndex = 0;
            this.textBarkod_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBarkod_No_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod No:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Müşteri Seç / Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textMusteriID
            // 
            this.textMusteriID.Location = new System.Drawing.Point(21, 127);
            this.textMusteriID.Name = "textMusteriID";
            this.textMusteriID.ReadOnly = true;
            this.textMusteriID.Size = new System.Drawing.Size(211, 20);
            this.textMusteriID.TabIndex = 3;
            this.textMusteriID.TextChanged += new System.EventHandler(this.textMusteri_adi_TextChanged);
            // 
            // lblFiyat
            // 
            this.lblFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(977, 33);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(237, 91);
            this.lblFiyat.TabIndex = 55;
            this.lblFiyat.Text = "000,0";
            this.lblFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(827, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(387, 69);
            this.button2.TabIndex = 6;
            this.button2.Text = "SAT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMusteri_adi
            // 
            this.txtMusteri_adi.Location = new System.Drawing.Point(21, 80);
            this.txtMusteri_adi.Name = "txtMusteri_adi";
            this.txtMusteri_adi.ReadOnly = true;
            this.txtMusteri_adi.Size = new System.Drawing.Size(211, 20);
            this.txtMusteri_adi.TabIndex = 7;
            this.txtMusteri_adi.TextChanged += new System.EventHandler(this.txtMusteri_adi_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "ÜRÜNÜ GİR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(21, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 323);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Barkod No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Açıklaması";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fiyat";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adet";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sil";
            this.Column5.Name = "Column5";
            this.Column5.Text = "Ürünü Sil";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(913, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 91);
            this.label2.TabIndex = 2;
            this.label2.Text = "₺";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 57;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kredi Kartı";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(123, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 58;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nakit";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1009, 500);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 59;
            this.checkBox1.Text = "Fiyata %10 İndirim Yap";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Müşteri Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Müşteri Kodu";
            // 
            // labelParaUstu
            // 
            this.labelParaUstu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParaUstu.AutoSize = true;
            this.labelParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelParaUstu.Location = new System.Drawing.Point(1161, 163);
            this.labelParaUstu.Name = "labelParaUstu";
            this.labelParaUstu.Size = new System.Drawing.Size(15, 16);
            this.labelParaUstu.TabIndex = 64;
            this.labelParaUstu.Text = "0";
            // 
            // txtAlinanUcret
            // 
            this.txtAlinanUcret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlinanUcret.Location = new System.Drawing.Point(1033, 140);
            this.txtAlinanUcret.Name = "txtAlinanUcret";
            this.txtAlinanUcret.Size = new System.Drawing.Size(181, 20);
            this.txtAlinanUcret.TabIndex = 65;
            this.txtAlinanUcret.TextChanged += new System.EventHandler(this.txtAlinanUcret_TextChanged);
            this.txtAlinanUcret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlinanUcret_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1030, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Alınan Ücret";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(806, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 46);
            this.button4.TabIndex = 67;
            this.button4.Text = "Rapor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(847, 500);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 68;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(824, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "İskonto:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(823, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "%";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(828, 523);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 23);
            this.button5.TabIndex = 71;
            this.button5.Text = "İndirimi Uygula";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(828, 523);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 23);
            this.button6.TabIndex = 72;
            this.button6.Text = "İndirimden Vazgeç";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonDegisim
            // 
            this.buttonDegisim.Location = new System.Drawing.Point(239, 13);
            this.buttonDegisim.Name = "buttonDegisim";
            this.buttonDegisim.Size = new System.Drawing.Size(86, 45);
            this.buttonDegisim.TabIndex = 73;
            this.buttonDegisim.Text = "Değişim";
            this.buttonDegisim.UseVisualStyleBackColor = true;
            this.buttonDegisim.Visible = false;
            this.buttonDegisim.Click += new System.EventHandler(this.buttonDegisim_Click);
            // 
            // buttonUrunEklebtn
            // 
            this.buttonUrunEklebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUrunEklebtn.Location = new System.Drawing.Point(706, 33);
            this.buttonUrunEklebtn.Name = "buttonUrunEklebtn";
            this.buttonUrunEklebtn.Size = new System.Drawing.Size(94, 46);
            this.buttonUrunEklebtn.TabIndex = 74;
            this.buttonUrunEklebtn.Text = "Ürün Ekle";
            this.buttonUrunEklebtn.UseVisualStyleBackColor = true;
            this.buttonUrunEklebtn.Visible = false;
            this.buttonUrunEklebtn.Click += new System.EventHandler(this.buttonUrunEklebtn_Click);
            // 
            // labelAdetokutuldu
            // 
            this.labelAdetokutuldu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAdetokutuldu.AutoSize = true;
            this.labelAdetokutuldu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdetokutuldu.Location = new System.Drawing.Point(30, 339);
            this.labelAdetokutuldu.Name = "labelAdetokutuldu";
            this.labelAdetokutuldu.Size = new System.Drawing.Size(163, 20);
            this.labelAdetokutuldu.TabIndex = 75;
            this.labelAdetokutuldu.Text = "0 Adet Ürün Okutuldu";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bonus",
            "World",
            "Maximum",
            "Axess",
            "Diğer"});
            this.comboBox1.Location = new System.Drawing.Point(25, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 76;
            this.comboBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelKKturu);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(806, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 119);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Şekli";
            // 
            // labelKKturu
            // 
            this.labelKKturu.AutoSize = true;
            this.labelKKturu.Location = new System.Drawing.Point(25, 62);
            this.labelKKturu.Name = "labelKKturu";
            this.labelKKturu.Size = new System.Drawing.Size(80, 13);
            this.labelKKturu.TabIndex = 77;
            this.labelKKturu.Text = "Kredi Kartı Türü";
            this.labelKKturu.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(647, 155);
            this.dataGridView2.TabIndex = 78;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Id";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Müşteri Kodu";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Barkod";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ürün Açıklaması";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Fiyat";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Ödeme Şekli";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Tarih";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // degisecekurunfiyati
            // 
            this.degisecekurunfiyati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.degisecekurunfiyati.AutoSize = true;
            this.degisecekurunfiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degisecekurunfiyati.Location = new System.Drawing.Point(594, 192);
            this.degisecekurunfiyati.Name = "degisecekurunfiyati";
            this.degisecekurunfiyati.Size = new System.Drawing.Size(39, 16);
            this.degisecekurunfiyati.TabIndex = 79;
            this.degisecekurunfiyati.Text = "000,0";
            this.degisecekurunfiyati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxdegisim
            // 
            this.groupBoxdegisim.Controls.Add(this.label9);
            this.groupBoxdegisim.Controls.Add(this.odenecektutar);
            this.groupBoxdegisim.Controls.Add(this.label3);
            this.groupBoxdegisim.Controls.Add(this.dataGridView2);
            this.groupBoxdegisim.Controls.Add(this.degisecekurunfiyati);
            this.groupBoxdegisim.Location = new System.Drawing.Point(250, 85);
            this.groupBoxdegisim.Name = "groupBoxdegisim";
            this.groupBoxdegisim.Size = new System.Drawing.Size(661, 219);
            this.groupBoxdegisim.TabIndex = 80;
            this.groupBoxdegisim.TabStop = false;
            this.groupBoxdegisim.Text = "Değişim";
            this.groupBoxdegisim.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Ödenecek Tutar";
            // 
            // odenecektutar
            // 
            this.odenecektutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.odenecektutar.AutoSize = true;
            this.odenecektutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odenecektutar.Location = new System.Drawing.Point(484, 192);
            this.odenecektutar.Name = "odenecektutar";
            this.odenecektutar.Size = new System.Drawing.Size(39, 16);
            this.odenecektutar.TabIndex = 81;
            this.odenecektutar.Text = "000,0";
            this.odenecektutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Toplam Fiyat";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(806, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(484, 20);
            this.progressBar1.TabIndex = 81;
            this.progressBar1.Visible = false;
            // 
            // satis
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 697);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBoxdegisim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAdetokutuldu);
            this.Controls.Add(this.buttonUrunEklebtn);
            this.Controls.Add(this.buttonDegisim);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAlinanUcret);
            this.Controls.Add(this.labelParaUstu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtMusteri_adi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.textMusteriID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBarkod_No);
            this.MinimumSize = new System.Drawing.Size(1220, 709);
            this.Name = "satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "satis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.satis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxdegisim.ResumeLayout(false);
            this.groupBoxdegisim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBarkod_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textMusteriID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMusteri_adi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelParaUstu;
        private System.Windows.Forms.TextBox txtAlinanUcret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonDegisim;
        private System.Windows.Forms.Button buttonUrunEklebtn;
        private System.Windows.Forms.Label labelAdetokutuldu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelKKturu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Label degisecekurunfiyati;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label odenecektutar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBoxdegisim;
        public System.Windows.Forms.Label lblFiyat;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}