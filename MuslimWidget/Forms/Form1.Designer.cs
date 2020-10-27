namespace MuslimWidget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wbAzan = new Gecko.GeckoWebBrowser();
            this.timer_remaining_time = new System.Windows.Forms.Timer(this.components);
            this.flp_Times = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlAzanTop = new System.Windows.Forms.Panel();
            this.cbx_Cities = new System.Windows.Forms.ComboBox();
            this.lbl_default_city = new System.Windows.Forms.Label();
            this.lbl_date_today = new System.Windows.Forms.Label();
            this.pnlAzanTimes = new System.Windows.Forms.Panel();
            this.pnlYatsi = new System.Windows.Forms.Panel();
            this.lbl_yatsi_time = new System.Windows.Forms.Label();
            this.lbl_yatsi_title = new System.Windows.Forms.Label();
            this.pnlAksam = new System.Windows.Forms.Panel();
            this.lbl_aksam_time = new System.Windows.Forms.Label();
            this.lbl_aksam_title = new System.Windows.Forms.Label();
            this.pnlIkindi = new System.Windows.Forms.Panel();
            this.lbl_ikindi_time = new System.Windows.Forms.Label();
            this.lbl_ikindi_title = new System.Windows.Forms.Label();
            this.pnlOgle = new System.Windows.Forms.Panel();
            this.lbl_ogle_time = new System.Windows.Forms.Label();
            this.lbl_ogle_title = new System.Windows.Forms.Label();
            this.pnlGunes = new System.Windows.Forms.Panel();
            this.lbl_gunes_time = new System.Windows.Forms.Label();
            this.lbl_gunes_title = new System.Windows.Forms.Label();
            this.pnlImsak = new System.Windows.Forms.Panel();
            this.lbl_imsak_time = new System.Windows.Forms.Label();
            this.lbl_imsak_title = new System.Windows.Forms.Label();
            this.pnlAzanRight = new System.Windows.Forms.Panel();
            this.lbl_next_time = new System.Windows.Forms.Label();
            this.lbl_remaining_time = new System.Windows.Forms.Label();
            this.btnDownloadData = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnAyarlar = new System.Windows.Forms.PictureBox();
            this.btnDuvarKagidi = new System.Windows.Forms.PictureBox();
            this.btnZikirMatik = new System.Windows.Forms.PictureBox();
            this.btnKazaTakip = new System.Windows.Forms.PictureBox();
            this.btnKuran = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_notification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_showme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eZANVAKTİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.pnlAzanTop.SuspendLayout();
            this.pnlAzanTimes.SuspendLayout();
            this.pnlYatsi.SuspendLayout();
            this.pnlAksam.SuspendLayout();
            this.pnlIkindi.SuspendLayout();
            this.pnlOgle.SuspendLayout();
            this.pnlGunes.SuspendLayout();
            this.pnlImsak.SuspendLayout();
            this.pnlAzanRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadData)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuvarKagidi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZikirMatik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKazaTakip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKuran)).BeginInit();
            this.cms_notification.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbAzan
            // 
            this.wbAzan.FrameEventsPropagateToMainWindow = false;
            this.wbAzan.Location = new System.Drawing.Point(0, 0);
            this.wbAzan.Name = "wbAzan";
            this.wbAzan.Size = new System.Drawing.Size(1, 1);
            this.wbAzan.TabIndex = 1;
            this.wbAzan.UseHttpActivityObserver = false;
            this.wbAzan.Visible = false;
            // 
            // timer_remaining_time
            // 
            this.timer_remaining_time.Interval = 1000;
            this.timer_remaining_time.Tick += new System.EventHandler(this.timer_kalan_süre_Tick);
            // 
            // flp_Times
            // 
            this.flp_Times.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Times.AutoScroll = true;
            this.flp_Times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.flp_Times.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_Times.Location = new System.Drawing.Point(12, 139);
            this.flp_Times.Name = "flp_Times";
            this.flp_Times.Size = new System.Drawing.Size(579, 243);
            this.flp_Times.TabIndex = 6;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlBottom.Location = new System.Drawing.Point(12, 388);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(579, 99);
            this.pnlBottom.TabIndex = 8;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlAzanTop);
            this.pnlMain.Controls.Add(this.pnlAzanTimes);
            this.pnlMain.Controls.Add(this.pnlAzanRight);
            this.pnlMain.Controls.Add(this.btnDownloadData);
            this.pnlMain.Controls.Add(this.flp_Times);
            this.pnlMain.Location = new System.Drawing.Point(56, 8);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(606, 492);
            this.pnlMain.TabIndex = 10;
            // 
            // pnlAzanTop
            // 
            this.pnlAzanTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAzanTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlAzanTop.BackgroundImage = global::MuslimWidget.Properties.Resources.top_bar;
            this.pnlAzanTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAzanTop.Controls.Add(this.cbx_Cities);
            this.pnlAzanTop.Controls.Add(this.lbl_default_city);
            this.pnlAzanTop.Controls.Add(this.lbl_date_today);
            this.pnlAzanTop.Location = new System.Drawing.Point(12, 10);
            this.pnlAzanTop.Name = "pnlAzanTop";
            this.pnlAzanTop.Size = new System.Drawing.Size(426, 30);
            this.pnlAzanTop.TabIndex = 4;
            // 
            // cbx_Cities
            // 
            this.cbx_Cities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Cities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.cbx_Cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Cities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Cities.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_Cities.ForeColor = System.Drawing.Color.White;
            this.cbx_Cities.FormattingEnabled = true;
            this.cbx_Cities.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "Istanbul",
            "Izmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kirikkale",
            "Kirklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şirnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cbx_Cities.Location = new System.Drawing.Point(270, 3);
            this.cbx_Cities.Name = "cbx_Cities";
            this.cbx_Cities.Size = new System.Drawing.Size(142, 24);
            this.cbx_Cities.TabIndex = 0;
            this.cbx_Cities.Visible = false;
            this.cbx_Cities.SelectedIndexChanged += new System.EventHandler(this.cbx_Cities_SelectedIndexChanged);
            // 
            // lbl_default_city
            // 
            this.lbl_default_city.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_default_city.AutoSize = true;
            this.lbl_default_city.BackColor = System.Drawing.Color.Transparent;
            this.lbl_default_city.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_default_city.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_default_city.ForeColor = System.Drawing.Color.White;
            this.lbl_default_city.Location = new System.Drawing.Point(392, 6);
            this.lbl_default_city.Name = "lbl_default_city";
            this.lbl_default_city.Size = new System.Drawing.Size(28, 18);
            this.lbl_default_city.TabIndex = 7;
            this.lbl_default_city.Text = "... ";
            this.lbl_default_city.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbl_default_city, "Şehir seç");
            this.lbl_default_city.Click += new System.EventHandler(this.lbl_default_city_Click);
            // 
            // lbl_date_today
            // 
            this.lbl_date_today.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date_today.AutoSize = true;
            this.lbl_date_today.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date_today.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_date_today.ForeColor = System.Drawing.Color.White;
            this.lbl_date_today.Location = new System.Drawing.Point(15, 5);
            this.lbl_date_today.Name = "lbl_date_today";
            this.lbl_date_today.Size = new System.Drawing.Size(89, 18);
            this.lbl_date_today.TabIndex = 6;
            this.lbl_date_today.Text = "Yükleniyor...";
            this.lbl_date_today.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAzanTimes
            // 
            this.pnlAzanTimes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAzanTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlAzanTimes.BackgroundImage = global::MuslimWidget.Properties.Resources.main_bar;
            this.pnlAzanTimes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAzanTimes.Controls.Add(this.pnlYatsi);
            this.pnlAzanTimes.Controls.Add(this.pnlAksam);
            this.pnlAzanTimes.Controls.Add(this.pnlIkindi);
            this.pnlAzanTimes.Controls.Add(this.pnlOgle);
            this.pnlAzanTimes.Controls.Add(this.pnlGunes);
            this.pnlAzanTimes.Controls.Add(this.pnlImsak);
            this.pnlAzanTimes.Location = new System.Drawing.Point(12, 43);
            this.pnlAzanTimes.Name = "pnlAzanTimes";
            this.pnlAzanTimes.Size = new System.Drawing.Size(452, 90);
            this.pnlAzanTimes.TabIndex = 3;
            // 
            // pnlYatsi
            // 
            this.pnlYatsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlYatsi.BackColor = System.Drawing.Color.Transparent;
            this.pnlYatsi.Controls.Add(this.lbl_yatsi_time);
            this.pnlYatsi.Controls.Add(this.lbl_yatsi_title);
            this.pnlYatsi.Location = new System.Drawing.Point(380, 13);
            this.pnlYatsi.Name = "pnlYatsi";
            this.pnlYatsi.Size = new System.Drawing.Size(65, 65);
            this.pnlYatsi.TabIndex = 10;
            // 
            // lbl_yatsi_time
            // 
            this.lbl_yatsi_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_yatsi_time.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yatsi_time.ForeColor = System.Drawing.Color.White;
            this.lbl_yatsi_time.Location = new System.Drawing.Point(4, 10);
            this.lbl_yatsi_time.Name = "lbl_yatsi_time";
            this.lbl_yatsi_time.Size = new System.Drawing.Size(57, 25);
            this.lbl_yatsi_time.TabIndex = 5;
            this.lbl_yatsi_time.Text = "...";
            this.lbl_yatsi_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_yatsi_title
            // 
            this.lbl_yatsi_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_yatsi_title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yatsi_title.ForeColor = System.Drawing.Color.White;
            this.lbl_yatsi_title.Location = new System.Drawing.Point(7, 37);
            this.lbl_yatsi_title.Name = "lbl_yatsi_title";
            this.lbl_yatsi_title.Size = new System.Drawing.Size(52, 25);
            this.lbl_yatsi_title.TabIndex = 4;
            this.lbl_yatsi_title.Text = "Yatsı";
            this.lbl_yatsi_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAksam
            // 
            this.pnlAksam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAksam.BackColor = System.Drawing.Color.Transparent;
            this.pnlAksam.Controls.Add(this.lbl_aksam_time);
            this.pnlAksam.Controls.Add(this.lbl_aksam_title);
            this.pnlAksam.Location = new System.Drawing.Point(309, 13);
            this.pnlAksam.Name = "pnlAksam";
            this.pnlAksam.Size = new System.Drawing.Size(65, 65);
            this.pnlAksam.TabIndex = 9;
            // 
            // lbl_aksam_time
            // 
            this.lbl_aksam_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_aksam_time.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aksam_time.ForeColor = System.Drawing.Color.White;
            this.lbl_aksam_time.Location = new System.Drawing.Point(4, 10);
            this.lbl_aksam_time.Name = "lbl_aksam_time";
            this.lbl_aksam_time.Size = new System.Drawing.Size(57, 25);
            this.lbl_aksam_time.TabIndex = 5;
            this.lbl_aksam_time.Text = "...";
            this.lbl_aksam_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_aksam_title
            // 
            this.lbl_aksam_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_aksam_title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aksam_title.ForeColor = System.Drawing.Color.White;
            this.lbl_aksam_title.Location = new System.Drawing.Point(7, 37);
            this.lbl_aksam_title.Name = "lbl_aksam_title";
            this.lbl_aksam_title.Size = new System.Drawing.Size(52, 25);
            this.lbl_aksam_title.TabIndex = 4;
            this.lbl_aksam_title.Text = "Akşam";
            this.lbl_aksam_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIkindi
            // 
            this.pnlIkindi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIkindi.BackColor = System.Drawing.Color.Transparent;
            this.pnlIkindi.Controls.Add(this.lbl_ikindi_time);
            this.pnlIkindi.Controls.Add(this.lbl_ikindi_title);
            this.pnlIkindi.Location = new System.Drawing.Point(238, 13);
            this.pnlIkindi.Name = "pnlIkindi";
            this.pnlIkindi.Size = new System.Drawing.Size(65, 65);
            this.pnlIkindi.TabIndex = 8;
            // 
            // lbl_ikindi_time
            // 
            this.lbl_ikindi_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ikindi_time.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ikindi_time.ForeColor = System.Drawing.Color.White;
            this.lbl_ikindi_time.Location = new System.Drawing.Point(4, 10);
            this.lbl_ikindi_time.Name = "lbl_ikindi_time";
            this.lbl_ikindi_time.Size = new System.Drawing.Size(57, 25);
            this.lbl_ikindi_time.TabIndex = 5;
            this.lbl_ikindi_time.Text = "...";
            this.lbl_ikindi_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ikindi_title
            // 
            this.lbl_ikindi_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ikindi_title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ikindi_title.ForeColor = System.Drawing.Color.White;
            this.lbl_ikindi_title.Location = new System.Drawing.Point(7, 37);
            this.lbl_ikindi_title.Name = "lbl_ikindi_title";
            this.lbl_ikindi_title.Size = new System.Drawing.Size(52, 25);
            this.lbl_ikindi_title.TabIndex = 4;
            this.lbl_ikindi_title.Text = "İkindi";
            this.lbl_ikindi_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOgle
            // 
            this.pnlOgle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOgle.BackColor = System.Drawing.Color.Transparent;
            this.pnlOgle.Controls.Add(this.lbl_ogle_time);
            this.pnlOgle.Controls.Add(this.lbl_ogle_title);
            this.pnlOgle.Location = new System.Drawing.Point(167, 13);
            this.pnlOgle.Name = "pnlOgle";
            this.pnlOgle.Size = new System.Drawing.Size(65, 65);
            this.pnlOgle.TabIndex = 7;
            // 
            // lbl_ogle_time
            // 
            this.lbl_ogle_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ogle_time.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogle_time.ForeColor = System.Drawing.Color.White;
            this.lbl_ogle_time.Location = new System.Drawing.Point(4, 10);
            this.lbl_ogle_time.Name = "lbl_ogle_time";
            this.lbl_ogle_time.Size = new System.Drawing.Size(57, 25);
            this.lbl_ogle_time.TabIndex = 5;
            this.lbl_ogle_time.Text = "...";
            this.lbl_ogle_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ogle_title
            // 
            this.lbl_ogle_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ogle_title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogle_title.ForeColor = System.Drawing.Color.White;
            this.lbl_ogle_title.Location = new System.Drawing.Point(7, 37);
            this.lbl_ogle_title.Name = "lbl_ogle_title";
            this.lbl_ogle_title.Size = new System.Drawing.Size(52, 25);
            this.lbl_ogle_title.TabIndex = 4;
            this.lbl_ogle_title.Text = "Öğle";
            this.lbl_ogle_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGunes
            // 
            this.pnlGunes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGunes.BackColor = System.Drawing.Color.Transparent;
            this.pnlGunes.Controls.Add(this.lbl_gunes_time);
            this.pnlGunes.Controls.Add(this.lbl_gunes_title);
            this.pnlGunes.Location = new System.Drawing.Point(96, 13);
            this.pnlGunes.Name = "pnlGunes";
            this.pnlGunes.Size = new System.Drawing.Size(65, 65);
            this.pnlGunes.TabIndex = 6;
            // 
            // lbl_gunes_time
            // 
            this.lbl_gunes_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gunes_time.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gunes_time.ForeColor = System.Drawing.Color.White;
            this.lbl_gunes_time.Location = new System.Drawing.Point(4, 10);
            this.lbl_gunes_time.Name = "lbl_gunes_time";
            this.lbl_gunes_time.Size = new System.Drawing.Size(57, 25);
            this.lbl_gunes_time.TabIndex = 5;
            this.lbl_gunes_time.Text = "...";
            this.lbl_gunes_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_gunes_title
            // 
            this.lbl_gunes_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gunes_title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gunes_title.ForeColor = System.Drawing.Color.White;
            this.lbl_gunes_title.Location = new System.Drawing.Point(7, 37);
            this.lbl_gunes_title.Name = "lbl_gunes_title";
            this.lbl_gunes_title.Size = new System.Drawing.Size(52, 25);
            this.lbl_gunes_title.TabIndex = 4;
            this.lbl_gunes_title.Text = "Güneş";
            this.lbl_gunes_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlImsak
            // 
            this.pnlImsak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImsak.BackColor = System.Drawing.Color.Transparent;
            this.pnlImsak.Controls.Add(this.lbl_imsak_time);
            this.pnlImsak.Controls.Add(this.lbl_imsak_title);
            this.pnlImsak.Location = new System.Drawing.Point(25, 13);
            this.pnlImsak.Name = "pnlImsak";
            this.pnlImsak.Size = new System.Drawing.Size(65, 65);
            this.pnlImsak.TabIndex = 0;
            // 
            // lbl_imsak_time
            // 
            this.lbl_imsak_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_imsak_time.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_imsak_time.ForeColor = System.Drawing.Color.White;
            this.lbl_imsak_time.Location = new System.Drawing.Point(4, 10);
            this.lbl_imsak_time.Name = "lbl_imsak_time";
            this.lbl_imsak_time.Size = new System.Drawing.Size(57, 25);
            this.lbl_imsak_time.TabIndex = 5;
            this.lbl_imsak_time.Text = "...";
            this.lbl_imsak_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_imsak_title
            // 
            this.lbl_imsak_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_imsak_title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_imsak_title.ForeColor = System.Drawing.Color.White;
            this.lbl_imsak_title.Location = new System.Drawing.Point(7, 37);
            this.lbl_imsak_title.Name = "lbl_imsak_title";
            this.lbl_imsak_title.Size = new System.Drawing.Size(52, 25);
            this.lbl_imsak_title.TabIndex = 4;
            this.lbl_imsak_title.Text = "İmsak";
            this.lbl_imsak_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAzanRight
            // 
            this.pnlAzanRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAzanRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlAzanRight.BackgroundImage = global::MuslimWidget.Properties.Resources.right_bar;
            this.pnlAzanRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAzanRight.Controls.Add(this.lbl_next_time);
            this.pnlAzanRight.Controls.Add(this.lbl_remaining_time);
            this.pnlAzanRight.Location = new System.Drawing.Point(470, 10);
            this.pnlAzanRight.Name = "pnlAzanRight";
            this.pnlAzanRight.Size = new System.Drawing.Size(123, 123);
            this.pnlAzanRight.TabIndex = 5;
            // 
            // lbl_next_time
            // 
            this.lbl_next_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_next_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_next_time.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_next_time.ForeColor = System.Drawing.Color.White;
            this.lbl_next_time.Location = new System.Drawing.Point(3, 9);
            this.lbl_next_time.Name = "lbl_next_time";
            this.lbl_next_time.Size = new System.Drawing.Size(117, 59);
            this.lbl_next_time.TabIndex = 7;
            this.lbl_next_time.Text = "Yükleniyor...";
            this.lbl_next_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_remaining_time
            // 
            this.lbl_remaining_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_remaining_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_remaining_time.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_remaining_time.ForeColor = System.Drawing.Color.White;
            this.lbl_remaining_time.Location = new System.Drawing.Point(3, 68);
            this.lbl_remaining_time.Name = "lbl_remaining_time";
            this.lbl_remaining_time.Size = new System.Drawing.Size(117, 43);
            this.lbl_remaining_time.TabIndex = 6;
            this.lbl_remaining_time.Text = "00:00";
            this.lbl_remaining_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDownloadData
            // 
            this.btnDownloadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownloadData.Image = global::MuslimWidget.Properties.Resources.refresh__1_;
            this.btnDownloadData.Location = new System.Drawing.Point(441, 12);
            this.btnDownloadData.Name = "btnDownloadData";
            this.btnDownloadData.Size = new System.Drawing.Size(25, 25);
            this.btnDownloadData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDownloadData.TabIndex = 7;
            this.btnDownloadData.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDownloadData, "İnternetten güncelle");
            this.btnDownloadData.Click += new System.EventHandler(this.btnDownloadData_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlLeft.BackgroundImage = global::MuslimWidget.Properties.Resources.bar_left_;
            this.pnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeft.Controls.Add(this.btnAyarlar);
            this.pnlLeft.Controls.Add(this.btnDuvarKagidi);
            this.pnlLeft.Controls.Add(this.btnZikirMatik);
            this.pnlLeft.Controls.Add(this.btnKazaTakip);
            this.pnlLeft.Controls.Add(this.btnKuran);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(50, 502);
            this.pnlLeft.TabIndex = 9;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.Location = new System.Drawing.Point(5, 210);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(40, 40);
            this.btnAyarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAyarlar, "AYARLAR");
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnDuvarKagidi
            // 
            this.btnDuvarKagidi.BackColor = System.Drawing.Color.Transparent;
            this.btnDuvarKagidi.Image = ((System.Drawing.Image)(resources.GetObject("btnDuvarKagidi.Image")));
            this.btnDuvarKagidi.Location = new System.Drawing.Point(5, 160);
            this.btnDuvarKagidi.Name = "btnDuvarKagidi";
            this.btnDuvarKagidi.Size = new System.Drawing.Size(40, 40);
            this.btnDuvarKagidi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDuvarKagidi.TabIndex = 3;
            this.btnDuvarKagidi.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDuvarKagidi, "DUVAR KAĞITLARI");
            this.btnDuvarKagidi.Click += new System.EventHandler(this.btnDuvarKagidi_Click);
            // 
            // btnZikirMatik
            // 
            this.btnZikirMatik.BackColor = System.Drawing.Color.Transparent;
            this.btnZikirMatik.Image = ((System.Drawing.Image)(resources.GetObject("btnZikirMatik.Image")));
            this.btnZikirMatik.Location = new System.Drawing.Point(5, 110);
            this.btnZikirMatik.Name = "btnZikirMatik";
            this.btnZikirMatik.Size = new System.Drawing.Size(40, 40);
            this.btnZikirMatik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZikirMatik.TabIndex = 2;
            this.btnZikirMatik.TabStop = false;
            this.toolTip1.SetToolTip(this.btnZikirMatik, "ZİKİR MATİK");
            this.btnZikirMatik.Click += new System.EventHandler(this.btnZikirMatik_Click);
            // 
            // btnKazaTakip
            // 
            this.btnKazaTakip.BackColor = System.Drawing.Color.Transparent;
            this.btnKazaTakip.Image = ((System.Drawing.Image)(resources.GetObject("btnKazaTakip.Image")));
            this.btnKazaTakip.Location = new System.Drawing.Point(5, 60);
            this.btnKazaTakip.Name = "btnKazaTakip";
            this.btnKazaTakip.Size = new System.Drawing.Size(40, 40);
            this.btnKazaTakip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKazaTakip.TabIndex = 1;
            this.btnKazaTakip.TabStop = false;
            this.toolTip1.SetToolTip(this.btnKazaTakip, "KAZA TAKİBİ");
            this.btnKazaTakip.Click += new System.EventHandler(this.btnKazaTakip_Click);
            // 
            // btnKuran
            // 
            this.btnKuran.BackColor = System.Drawing.Color.Transparent;
            this.btnKuran.Image = ((System.Drawing.Image)(resources.GetObject("btnKuran.Image")));
            this.btnKuran.Location = new System.Drawing.Point(5, 10);
            this.btnKuran.Name = "btnKuran";
            this.btnKuran.Size = new System.Drawing.Size(40, 40);
            this.btnKuran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKuran.TabIndex = 0;
            this.btnKuran.TabStop = false;
            this.toolTip1.SetToolTip(this.btnKuran, "KUR\'AN TÜRKÇE MEÂL");
            this.btnKuran.Click += new System.EventHandler(this.btnKuran_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cms_notification;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Ezan Vakti";
            // 
            // cms_notification
            // 
            this.cms_notification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eZANVAKTİToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsmi_showme,
            this.tsmi_close});
            this.cms_notification.Name = "cms_notification";
            this.cms_notification.Size = new System.Drawing.Size(181, 98);
            // 
            // tsmi_showme
            // 
            this.tsmi_showme.Name = "tsmi_showme";
            this.tsmi_showme.Size = new System.Drawing.Size(180, 22);
            this.tsmi_showme.Text = "Programı Göster";
            this.tsmi_showme.Click += new System.EventHandler(this.tsmi_showme_Click);
            // 
            // tsmi_close
            // 
            this.tsmi_close.Name = "tsmi_close";
            this.tsmi_close.Size = new System.Drawing.Size(180, 22);
            this.tsmi_close.Text = "Çıkış";
            this.tsmi_close.Click += new System.EventHandler(this.tsmi_close_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // eZANVAKTİToolStripMenuItem
            // 
            this.eZANVAKTİToolStripMenuItem.Enabled = false;
            this.eZANVAKTİToolStripMenuItem.Name = "eZANVAKTİToolStripMenuItem";
            this.eZANVAKTİToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eZANVAKTİToolStripMenuItem.Text = "EZAN VAKTİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(674, 502);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.wbAzan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(690, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ezan Vakti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlAzanTop.ResumeLayout(false);
            this.pnlAzanTop.PerformLayout();
            this.pnlAzanTimes.ResumeLayout(false);
            this.pnlYatsi.ResumeLayout(false);
            this.pnlAksam.ResumeLayout(false);
            this.pnlIkindi.ResumeLayout(false);
            this.pnlOgle.ResumeLayout(false);
            this.pnlGunes.ResumeLayout(false);
            this.pnlImsak.ResumeLayout(false);
            this.pnlAzanRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadData)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuvarKagidi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZikirMatik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKazaTakip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKuran)).EndInit();
            this.cms_notification.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Gecko.GeckoWebBrowser wbAzan;
        private System.Windows.Forms.Panel pnlAzanTimes;
        private System.Windows.Forms.Panel pnlImsak;
        private System.Windows.Forms.Label lbl_imsak_title;
        private System.Windows.Forms.Panel pnlYatsi;
        private System.Windows.Forms.Label lbl_yatsi_time;
        private System.Windows.Forms.Label lbl_yatsi_title;
        private System.Windows.Forms.Panel pnlAksam;
        private System.Windows.Forms.Label lbl_aksam_time;
        private System.Windows.Forms.Label lbl_aksam_title;
        private System.Windows.Forms.Panel pnlIkindi;
        private System.Windows.Forms.Label lbl_ikindi_time;
        private System.Windows.Forms.Label lbl_ikindi_title;
        private System.Windows.Forms.Panel pnlOgle;
        private System.Windows.Forms.Label lbl_ogle_time;
        private System.Windows.Forms.Label lbl_ogle_title;
        private System.Windows.Forms.Panel pnlGunes;
        private System.Windows.Forms.Label lbl_gunes_time;
        private System.Windows.Forms.Label lbl_gunes_title;
        private System.Windows.Forms.Label lbl_imsak_time;
        private System.Windows.Forms.Panel pnlAzanTop;
        private System.Windows.Forms.Label lbl_date_today;
        private System.Windows.Forms.Panel pnlAzanRight;
        private System.Windows.Forms.Label lbl_next_time;
        private System.Windows.Forms.Label lbl_remaining_time;
        private System.Windows.Forms.Timer timer_remaining_time;
        private System.Windows.Forms.FlowLayoutPanel flp_Times;
        private System.Windows.Forms.ComboBox cbx_Cities;
        private System.Windows.Forms.Label lbl_default_city;
        private System.Windows.Forms.PictureBox btnDownloadData;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox btnDuvarKagidi;
        private System.Windows.Forms.PictureBox btnZikirMatik;
        private System.Windows.Forms.PictureBox btnKazaTakip;
        private System.Windows.Forms.PictureBox btnKuran;
        private System.Windows.Forms.PictureBox btnAyarlar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cms_notification;
        private System.Windows.Forms.ToolStripMenuItem tsmi_showme;
        private System.Windows.Forms.ToolStripMenuItem tsmi_close;
        private System.Windows.Forms.ToolStripMenuItem eZANVAKTİToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

