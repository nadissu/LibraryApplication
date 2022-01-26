namespace Kütüphane_BitirmeProjeSon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.emanetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ktphnDataSet = new Kütüphane_BitirmeProjeSon.ktphnDataSet();
            this.emanetTableAdapter = new Kütüphane_BitirmeProjeSon.ktphnDataSetTableAdapters.emanetTableAdapter();
            this.kitap_guncelle = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.emanet = new System.Windows.Forms.DataGridView();
            this.alindiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almatarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verilistarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanet_kitap_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanet_ogr_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.data_ogrenci = new System.Windows.Forms.DataGridView();
            this.ogrenci_tckn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenci_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenci_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenci_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.data_kitap = new System.Windows.Forms.DataGridView();
            this.kitap_konusu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_yazari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.emanet_ograd1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.emanet_al_kitap_ad = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.emanet_ograd2 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.emanet_ver_kitap_ad = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.emanet_Ver_not = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ogr_ekle_no = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ogr_ekle_mail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ogr_ekle_ad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ogr_ekle_tckn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ogr_duzenle_tel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ogr_duzenle_mail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ogr_duzenle_tckn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ogr_duzenle_adsoyad = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kitap_ad = new System.Windows.Forms.TextBox();
            this.kitap_yazar = new System.Windows.Forms.TextBox();
            this.kitap_konu = new System.Windows.Forms.TextBox();
            this.kitap_aciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitap_duzenle_ad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kitap_duzenle_yazar = new System.Windows.Forms.TextBox();
            this.kitap_duzenle_konu = new System.Windows.Forms.TextBox();
            this.kitap_duzenle_aciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktphnDataSet)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emanet)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ogrenci)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_kitap)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emanetBindingSource
            // 
            this.emanetBindingSource.DataMember = "emanet";
            this.emanetBindingSource.DataSource = this.ktphnDataSet;
            // 
            // ktphnDataSet
            // 
            this.ktphnDataSet.DataSetName = "ktphnDataSet";
            this.ktphnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanetTableAdapter
            // 
            this.emanetTableAdapter.ClearBeforeFill = true;
            // 
            // kitap_guncelle
            // 
            this.kitap_guncelle.Enabled = true;
            this.kitap_guncelle.Interval = 10000;
            this.kitap_guncelle.Tick += new System.EventHandler(this.kitap_guncelle_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.emanet);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(566, 411);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Emanet Listele";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // emanet
            // 
            this.emanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emanet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emanet_ogr_ad,
            this.emanet_kitap_ad,
            this.verilistarihDataGridViewTextBoxColumn,
            this.almatarihDataGridViewTextBoxColumn,
            this.notDataGridViewTextBoxColumn,
            this.alindiDataGridViewCheckBoxColumn});
            this.emanet.Location = new System.Drawing.Point(4, 5);
            this.emanet.Margin = new System.Windows.Forms.Padding(2);
            this.emanet.Name = "emanet";
            this.emanet.RowTemplate.Height = 24;
            this.emanet.Size = new System.Drawing.Size(554, 404);
            this.emanet.TabIndex = 0;
            this.emanet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // alindiDataGridViewCheckBoxColumn
            // 
            this.alindiDataGridViewCheckBoxColumn.HeaderText = "Alındı";
            this.alindiDataGridViewCheckBoxColumn.Name = "alindiDataGridViewCheckBoxColumn";
            // 
            // notDataGridViewTextBoxColumn
            // 
            this.notDataGridViewTextBoxColumn.HeaderText = "Not";
            this.notDataGridViewTextBoxColumn.Name = "notDataGridViewTextBoxColumn";
            // 
            // almatarihDataGridViewTextBoxColumn
            // 
            this.almatarihDataGridViewTextBoxColumn.HeaderText = "Alma Tarihi";
            this.almatarihDataGridViewTextBoxColumn.Name = "almatarihDataGridViewTextBoxColumn";
            this.almatarihDataGridViewTextBoxColumn.Width = 75;
            // 
            // verilistarihDataGridViewTextBoxColumn
            // 
            this.verilistarihDataGridViewTextBoxColumn.HeaderText = "Veriliş Tarihi";
            this.verilistarihDataGridViewTextBoxColumn.Name = "verilistarihDataGridViewTextBoxColumn";
            this.verilistarihDataGridViewTextBoxColumn.Width = 75;
            // 
            // emanet_kitap_ad
            // 
            this.emanet_kitap_ad.HeaderText = "Kitap Adı";
            this.emanet_kitap_ad.Name = "emanet_kitap_ad";
            this.emanet_kitap_ad.Width = 75;
            // 
            // emanet_ogr_ad
            // 
            this.emanet_ogr_ad.HeaderText = "Öğrenci adı";
            this.emanet_ogr_ad.Name = "emanet_ogr_ad";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.data_ogrenci);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(566, 411);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Öğrenci Listele";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // data_ogrenci
            // 
            this.data_ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ogrenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenci_ad,
            this.ogrenci_mail,
            this.ogrenci_tel,
            this.ogrenci_tckn});
            this.data_ogrenci.Location = new System.Drawing.Point(4, 5);
            this.data_ogrenci.Margin = new System.Windows.Forms.Padding(2);
            this.data_ogrenci.Name = "data_ogrenci";
            this.data_ogrenci.RowTemplate.Height = 24;
            this.data_ogrenci.Size = new System.Drawing.Size(560, 404);
            this.data_ogrenci.TabIndex = 0;
            // 
            // ogrenci_tckn
            // 
            this.ogrenci_tckn.HeaderText = "Öğrenci TCKN";
            this.ogrenci_tckn.Name = "ogrenci_tckn";
            this.ogrenci_tckn.ReadOnly = true;
            // 
            // ogrenci_tel
            // 
            this.ogrenci_tel.HeaderText = "Öğrenci Telefonu";
            this.ogrenci_tel.Name = "ogrenci_tel";
            this.ogrenci_tel.ReadOnly = true;
            // 
            // ogrenci_mail
            // 
            this.ogrenci_mail.HeaderText = "Öğrenci Maili";
            this.ogrenci_mail.Name = "ogrenci_mail";
            this.ogrenci_mail.ReadOnly = true;
            // 
            // ogrenci_ad
            // 
            this.ogrenci_ad.HeaderText = "Öğrenci Adı";
            this.ogrenci_ad.Name = "ogrenci_ad";
            this.ogrenci_ad.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.data_kitap);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(566, 411);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kitap Listele";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // data_kitap
            // 
            this.data_kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_kitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitap_adi,
            this.kitap_yazari,
            this.kitap_stok,
            this.kitap_konusu});
            this.data_kitap.Location = new System.Drawing.Point(4, 5);
            this.data_kitap.Margin = new System.Windows.Forms.Padding(2);
            this.data_kitap.Name = "data_kitap";
            this.data_kitap.RowTemplate.Height = 24;
            this.data_kitap.Size = new System.Drawing.Size(554, 404);
            this.data_kitap.TabIndex = 0;
            // 
            // kitap_konusu
            // 
            this.kitap_konusu.HeaderText = "Kitap Konusu";
            this.kitap_konusu.Name = "kitap_konusu";
            this.kitap_konusu.ReadOnly = true;
            // 
            // kitap_stok
            // 
            this.kitap_stok.HeaderText = "Kitap Stoğu";
            this.kitap_stok.Name = "kitap_stok";
            this.kitap_stok.ReadOnly = true;
            // 
            // kitap_yazari
            // 
            this.kitap_yazari.HeaderText = "Kitap Yazarı";
            this.kitap_yazari.Name = "kitap_yazari";
            this.kitap_yazari.ReadOnly = true;
            // 
            // kitap_adi
            // 
            this.kitap_adi.HeaderText = "Kitap Adı";
            this.kitap_adi.Name = "kitap_adi";
            this.kitap_adi.ReadOnly = true;

            // 
            // emanet_ograd1
            // 
            this.emanet_ograd1.FormattingEnabled = true;
            this.emanet_ograd1.Location = new System.Drawing.Point(14, 60);
            this.emanet_ograd1.Margin = new System.Windows.Forms.Padding(2);
            this.emanet_ograd1.Name = "emanet_ograd1";
            this.emanet_ograd1.Size = new System.Drawing.Size(151, 21);
            this.emanet_ograd1.TabIndex = 0;
            this.emanet_ograd1.SelectedIndexChanged += new System.EventHandler(this.emanet_ograd1_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 32);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Öğrenci Adı Soyadı";
            // 
            // emanet_al_kitap_ad
            // 
            this.emanet_al_kitap_ad.FormattingEnabled = true;
            this.emanet_al_kitap_ad.Location = new System.Drawing.Point(14, 143);
            this.emanet_al_kitap_ad.Margin = new System.Windows.Forms.Padding(2);
            this.emanet_al_kitap_ad.Name = "emanet_al_kitap_ad";
            this.emanet_al_kitap_ad.Size = new System.Drawing.Size(151, 21);
            this.emanet_al_kitap_ad.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 115);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Kitap Adı (Teslim alınacak)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 212);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 193);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Emanet Alım Tarihi";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(199, 344);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 30);
            this.button7.TabIndex = 6;
            this.button7.Text = "Emaneti Al";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.emanet_Ver_not);
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.dateTimePicker2);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.emanet_ver_kitap_ad);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.emanet_ograd2);
            this.groupBox6.Location = new System.Drawing.Point(279, 16);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(278, 385);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Emanet Ver";
            // 
            // emanet_ograd2
            // 
            this.emanet_ograd2.FormattingEnabled = true;
            this.emanet_ograd2.Location = new System.Drawing.Point(14, 50);
            this.emanet_ograd2.Margin = new System.Windows.Forms.Padding(2);
            this.emanet_ograd2.Name = "emanet_ograd2";
            this.emanet_ograd2.Size = new System.Drawing.Size(151, 21);
            this.emanet_ograd2.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 21);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Öğrenci Adı Soyadı";
            // 
            // emanet_ver_kitap_ad
            // 
            this.emanet_ver_kitap_ad.FormattingEnabled = true;
            this.emanet_ver_kitap_ad.Location = new System.Drawing.Point(14, 132);
            this.emanet_ver_kitap_ad.Margin = new System.Windows.Forms.Padding(2);
            this.emanet_ver_kitap_ad.Name = "emanet_ver_kitap_ad";
            this.emanet_ver_kitap_ad.Size = new System.Drawing.Size(152, 21);
            this.emanet_ver_kitap_ad.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 104);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Kitap Adı";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(14, 202);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 183);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Emanet Getirme Tarihi(Teslim)";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(199, 342);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 41);
            this.button8.TabIndex = 13;
            this.button8.Text = "Emaneti Ver";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // emanet_Ver_not
            // 
            this.emanet_Ver_not.Location = new System.Drawing.Point(14, 245);
            this.emanet_Ver_not.Margin = new System.Windows.Forms.Padding(2);
            this.emanet_Ver_not.Multiline = true;
            this.emanet_Ver_not.Name = "emanet_Ver_not";
            this.emanet_Ver_not.Size = new System.Drawing.Size(260, 93);
            this.emanet_Ver_not.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 229);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Not";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(566, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Öğrenci Ekle / Düzenle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.ogr_ekle_tckn);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.ogr_ekle_ad);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ogr_ekle_mail);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ogr_ekle_no);
            this.groupBox3.Location = new System.Drawing.Point(3, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(271, 388);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Ekle";
            // 
            // ogr_ekle_no
            // 
            this.ogr_ekle_no.Location = new System.Drawing.Point(14, 199);
            this.ogr_ekle_no.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_ekle_no.Name = "ogr_ekle_no";
            this.ogr_ekle_no.Size = new System.Drawing.Size(104, 20);
            this.ogr_ekle_no.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Öğrenci Adı Soyadı";
            // 
            // ogr_ekle_mail
            // 
            this.ogr_ekle_mail.Location = new System.Drawing.Point(12, 128);
            this.ogr_ekle_mail.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_ekle_mail.Name = "ogr_ekle_mail";
            this.ogr_ekle_mail.Size = new System.Drawing.Size(107, 20);
            this.ogr_ekle_mail.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Öğrenci Maili";
            // 
            // ogr_ekle_ad
            // 
            this.ogr_ekle_ad.Location = new System.Drawing.Point(12, 58);
            this.ogr_ekle_ad.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_ekle_ad.Name = "ogr_ekle_ad";
            this.ogr_ekle_ad.Size = new System.Drawing.Size(107, 20);
            this.ogr_ekle_ad.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Öğrenci Telefon No\'su";
            // 
            // ogr_ekle_tckn
            // 
            this.ogr_ekle_tckn.Location = new System.Drawing.Point(12, 266);
            this.ogr_ekle_tckn.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_ekle_tckn.Name = "ogr_ekle_tckn";
            this.ogr_ekle_tckn.Size = new System.Drawing.Size(107, 20);
            this.ogr_ekle_tckn.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 237);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Öğrenci TCKN";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(181, 337);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ogr_duzenle_adsoyad);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.ogr_duzenle_tckn);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.ogr_duzenle_mail);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.ogr_duzenle_tel);
            this.groupBox4.Location = new System.Drawing.Point(278, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(271, 388);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğrenci Düzenle";
            // 
            // ogr_duzenle_tel
            // 
            this.ogr_duzenle_tel.Location = new System.Drawing.Point(20, 194);
            this.ogr_duzenle_tel.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_duzenle_tel.Name = "ogr_duzenle_tel";
            this.ogr_duzenle_tel.Size = new System.Drawing.Size(104, 20);
            this.ogr_duzenle_tel.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Öğrenci Adı Soyadı";
            // 
            // ogr_duzenle_mail
            // 
            this.ogr_duzenle_mail.Location = new System.Drawing.Point(17, 124);
            this.ogr_duzenle_mail.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_duzenle_mail.Name = "ogr_duzenle_mail";
            this.ogr_duzenle_mail.Size = new System.Drawing.Size(107, 20);
            this.ogr_duzenle_mail.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 92);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Öğrenci Maili";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 164);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Öğrenci Telefon No\'su";
            // 
            // ogr_duzenle_tckn
            // 
            this.ogr_duzenle_tckn.Location = new System.Drawing.Point(17, 261);
            this.ogr_duzenle_tckn.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_duzenle_tckn.Name = "ogr_duzenle_tckn";
            this.ogr_duzenle_tckn.Size = new System.Drawing.Size(107, 20);
            this.ogr_duzenle_tckn.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 232);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Öğrenci TCKN";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(188, 337);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 31);
            this.button5.TabIndex = 17;
            this.button5.Text = "Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 337);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 31);
            this.button6.TabIndex = 18;
            this.button6.Text = "Sil";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ogr_duzenle_adsoyad
            // 
            this.ogr_duzenle_adsoyad.FormattingEnabled = true;
            this.ogr_duzenle_adsoyad.Location = new System.Drawing.Point(17, 58);
            this.ogr_duzenle_adsoyad.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_duzenle_adsoyad.Name = "ogr_duzenle_adsoyad";
            this.ogr_duzenle_adsoyad.Size = new System.Drawing.Size(107, 21);
            this.ogr_duzenle_adsoyad.TabIndex = 19;
            this.ogr_duzenle_adsoyad.SelectedIndexChanged += new System.EventHandler(this.ogrekle_adsoyad_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(566, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitap Ekle / Düzenle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kitap_aciklama);
            this.groupBox1.Controls.Add(this.kitap_konu);
            this.groupBox1.Controls.Add(this.kitap_yazar);
            this.groupBox1.Controls.Add(this.kitap_ad);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(260, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekle";
            // 
            // kitap_ad
            // 
            this.kitap_ad.Location = new System.Drawing.Point(4, 45);
            this.kitap_ad.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_ad.Name = "kitap_ad";
            this.kitap_ad.Size = new System.Drawing.Size(113, 20);
            this.kitap_ad.TabIndex = 0;
            // 
            // kitap_yazar
            // 
            this.kitap_yazar.Location = new System.Drawing.Point(4, 95);
            this.kitap_yazar.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_yazar.Name = "kitap_yazar";
            this.kitap_yazar.Size = new System.Drawing.Size(113, 20);
            this.kitap_yazar.TabIndex = 1;
            // 
            // kitap_konu
            // 
            this.kitap_konu.Location = new System.Drawing.Point(5, 141);
            this.kitap_konu.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_konu.Name = "kitap_konu";
            this.kitap_konu.Size = new System.Drawing.Size(112, 20);
            this.kitap_konu.TabIndex = 2;
            // 
            // kitap_aciklama
            // 
            this.kitap_aciklama.Location = new System.Drawing.Point(5, 186);
            this.kitap_aciklama.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_aciklama.Multiline = true;
            this.kitap_aciklama.Name = "kitap_aciklama";
            this.kitap_aciklama.Size = new System.Drawing.Size(251, 164);
            this.kitap_aciklama.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitap Yazarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kitap Konuları";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kitap Açıklaması";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.kitap_duzenle_aciklama);
            this.groupBox2.Controls.Add(this.kitap_duzenle_konu);
            this.groupBox2.Controls.Add(this.kitap_duzenle_yazar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.kitap_duzenle_ad);
            this.groupBox2.Location = new System.Drawing.Point(275, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(289, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Düzenle";
            // 
            // kitap_duzenle_ad
            // 
            this.kitap_duzenle_ad.FormattingEnabled = true;
            this.kitap_duzenle_ad.Location = new System.Drawing.Point(13, 42);
            this.kitap_duzenle_ad.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_duzenle_ad.Name = "kitap_duzenle_ad";
            this.kitap_duzenle_ad.Size = new System.Drawing.Size(112, 21);
            this.kitap_duzenle_ad.TabIndex = 0;
            this.kitap_duzenle_ad.SelectedIndexChanged += new System.EventHandler(this.kitap_duzenle_ad_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kitap Adı";
            // 
            // kitap_duzenle_yazar
            // 
            this.kitap_duzenle_yazar.Location = new System.Drawing.Point(12, 94);
            this.kitap_duzenle_yazar.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_duzenle_yazar.Name = "kitap_duzenle_yazar";
            this.kitap_duzenle_yazar.Size = new System.Drawing.Size(113, 20);
            this.kitap_duzenle_yazar.TabIndex = 8;
            // 
            // kitap_duzenle_konu
            // 
            this.kitap_duzenle_konu.Location = new System.Drawing.Point(13, 140);
            this.kitap_duzenle_konu.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_duzenle_konu.Name = "kitap_duzenle_konu";
            this.kitap_duzenle_konu.Size = new System.Drawing.Size(112, 20);
            this.kitap_duzenle_konu.TabIndex = 9;
            // 
            // kitap_duzenle_aciklama
            // 
            this.kitap_duzenle_aciklama.Location = new System.Drawing.Point(13, 185);
            this.kitap_duzenle_aciklama.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_duzenle_aciklama.Multiline = true;
            this.kitap_duzenle_aciklama.Name = "kitap_duzenle_aciklama";
            this.kitap_duzenle_aciklama.Size = new System.Drawing.Size(251, 164);
            this.kitap_duzenle_aciklama.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kitap Yazarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kitap Konuları";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kitap Açıklaması";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 353);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Kitabı Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 354);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Kütüphane Otomasyonu Final";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktphnDataSet)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emanet)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_ogrenci)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_kitap)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ktphnDataSet ktphnDataSet;
        private System.Windows.Forms.BindingSource emanetBindingSource;
        private ktphnDataSetTableAdapters.emanetTableAdapter emanetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer kitap_guncelle;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView emanet;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanet_ogr_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanet_kitap_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn verilistarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almatarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alindiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView data_ogrenci;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenci_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenci_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenci_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenci_tckn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView data_kitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_yazari;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_konusu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox emanet_Ver_not;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox emanet_ver_kitap_ad;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox emanet_ograd2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox emanet_al_kitap_ad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox emanet_ograd1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox ogr_duzenle_adsoyad;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ogr_duzenle_tckn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ogr_duzenle_mail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ogr_duzenle_tel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ogr_ekle_tckn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ogr_ekle_ad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ogr_ekle_mail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ogr_ekle_no;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kitap_duzenle_aciklama;
        private System.Windows.Forms.TextBox kitap_duzenle_konu;
        private System.Windows.Forms.TextBox kitap_duzenle_yazar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox kitap_duzenle_ad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kitap_aciklama;
        private System.Windows.Forms.TextBox kitap_konu;
        private System.Windows.Forms.TextBox kitap_yazar;
        private System.Windows.Forms.TextBox kitap_ad;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

