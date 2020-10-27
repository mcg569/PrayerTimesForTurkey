namespace MuslimWidget
{
    partial class FormKazaTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKazaTakip));
            this.nud_sabah = new System.Windows.Forms.NumericUpDown();
            this.lbl_sabah_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_time_oruc = new System.Windows.Forms.Label();
            this.lbl_time_vitr = new System.Windows.Forms.Label();
            this.lbl_time_yatsi = new System.Windows.Forms.Label();
            this.lbl_time_aksam = new System.Windows.Forms.Label();
            this.lbl_time_ikindi = new System.Windows.Forms.Label();
            this.lbl_time_ogle = new System.Windows.Forms.Label();
            this.lbl_time_sabah = new System.Windows.Forms.Label();
            this.nud_oruc = new System.Windows.Forms.NumericUpDown();
            this.lbl_oruc_title = new System.Windows.Forms.Label();
            this.nud_vitr = new System.Windows.Forms.NumericUpDown();
            this.lbl_vitr_title = new System.Windows.Forms.Label();
            this.nud_yatsi = new System.Windows.Forms.NumericUpDown();
            this.lbl_yatsi_title = new System.Windows.Forms.Label();
            this.nud_aksam = new System.Windows.Forms.NumericUpDown();
            this.lbl_aksam_title = new System.Windows.Forms.Label();
            this.nud_ikindi = new System.Windows.Forms.NumericUpDown();
            this.lbl_ikindi_title = new System.Windows.Forms.Label();
            this.nud_ogle = new System.Windows.Forms.NumericUpDown();
            this.lbl_ogle_title = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_hesapsonucu = new System.Windows.Forms.Label();
            this.nud_yilsayisi = new System.Windows.Forms.NumericUpDown();
            this.lbl_kilinmayanyil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sabah)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_oruc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vitr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_yatsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aksam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ikindi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ogle)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_yilsayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_sabah
            // 
            this.nud_sabah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.nud_sabah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_sabah.ForeColor = System.Drawing.Color.GreenYellow;
            this.nud_sabah.Location = new System.Drawing.Point(151, 27);
            this.nud_sabah.Maximum = new decimal(new int[] {
            37000,
            0,
            0,
            0});
            this.nud_sabah.Name = "nud_sabah";
            this.nud_sabah.Size = new System.Drawing.Size(169, 27);
            this.nud_sabah.TabIndex = 0;
            this.nud_sabah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_sabah.ValueChanged += new System.EventHandler(this.nud_sabah_ValueChanged);
            // 
            // lbl_sabah_title
            // 
            this.lbl_sabah_title.AutoSize = true;
            this.lbl_sabah_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.lbl_sabah_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sabah_title.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_sabah_title.Location = new System.Drawing.Point(8, 33);
            this.lbl_sabah_title.Name = "lbl_sabah_title";
            this.lbl_sabah_title.Size = new System.Drawing.Size(126, 21);
            this.lbl_sabah_title.TabIndex = 1;
            this.lbl_sabah_title.Text = "Sabah namazı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_time_oruc);
            this.groupBox1.Controls.Add(this.lbl_time_vitr);
            this.groupBox1.Controls.Add(this.lbl_time_yatsi);
            this.groupBox1.Controls.Add(this.lbl_time_aksam);
            this.groupBox1.Controls.Add(this.lbl_time_ikindi);
            this.groupBox1.Controls.Add(this.lbl_time_ogle);
            this.groupBox1.Controls.Add(this.lbl_time_sabah);
            this.groupBox1.Controls.Add(this.nud_oruc);
            this.groupBox1.Controls.Add(this.lbl_oruc_title);
            this.groupBox1.Controls.Add(this.nud_vitr);
            this.groupBox1.Controls.Add(this.lbl_vitr_title);
            this.groupBox1.Controls.Add(this.nud_yatsi);
            this.groupBox1.Controls.Add(this.lbl_yatsi_title);
            this.groupBox1.Controls.Add(this.nud_aksam);
            this.groupBox1.Controls.Add(this.lbl_aksam_title);
            this.groupBox1.Controls.Add(this.nud_ikindi);
            this.groupBox1.Controls.Add(this.lbl_ikindi_title);
            this.groupBox1.Controls.Add(this.nud_ogle);
            this.groupBox1.Controls.Add(this.lbl_ogle_title);
            this.groupBox1.Controls.Add(this.nud_sabah);
            this.groupBox1.Controls.Add(this.lbl_sabah_title);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kaza takibi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "[SON GÜNCELLEME]";
            // 
            // lbl_time_oruc
            // 
            this.lbl_time_oruc.AutoSize = true;
            this.lbl_time_oruc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time_oruc.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_time_oruc.Location = new System.Drawing.Point(326, 231);
            this.lbl_time_oruc.Name = "lbl_time_oruc";
            this.lbl_time_oruc.Size = new System.Drawing.Size(108, 16);
            this.lbl_time_oruc.TabIndex = 20;
            this.lbl_time_oruc.Text = "dd.mm.yyy hh.mm";
            // 
            // lbl_time_vitr
            // 
            this.lbl_time_vitr.AutoSize = true;
            this.lbl_time_vitr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time_vitr.Location = new System.Drawing.Point(326, 198);
            this.lbl_time_vitr.Name = "lbl_time_vitr";
            this.lbl_time_vitr.Size = new System.Drawing.Size(108, 16);
            this.lbl_time_vitr.TabIndex = 19;
            this.lbl_time_vitr.Text = "dd.mm.yyy hh.mm";
            // 
            // lbl_time_yatsi
            // 
            this.lbl_time_yatsi.AutoSize = true;
            this.lbl_time_yatsi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time_yatsi.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_time_yatsi.Location = new System.Drawing.Point(326, 165);
            this.lbl_time_yatsi.Name = "lbl_time_yatsi";
            this.lbl_time_yatsi.Size = new System.Drawing.Size(108, 16);
            this.lbl_time_yatsi.TabIndex = 18;
            this.lbl_time_yatsi.Text = "dd.mm.yyy hh.mm";
            // 
            // lbl_time_aksam
            // 
            this.lbl_time_aksam.AutoSize = true;
            this.lbl_time_aksam.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time_aksam.Location = new System.Drawing.Point(326, 132);
            this.lbl_time_aksam.Name = "lbl_time_aksam";
            this.lbl_time_aksam.Size = new System.Drawing.Size(108, 16);
            this.lbl_time_aksam.TabIndex = 17;
            this.lbl_time_aksam.Text = "dd.mm.yyy hh.mm";
            // 
            // lbl_time_ikindi
            // 
            this.lbl_time_ikindi.AutoSize = true;
            this.lbl_time_ikindi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time_ikindi.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_time_ikindi.Location = new System.Drawing.Point(326, 99);
            this.lbl_time_ikindi.Name = "lbl_time_ikindi";
            this.lbl_time_ikindi.Size = new System.Drawing.Size(108, 16);
            this.lbl_time_ikindi.TabIndex = 16;
            this.lbl_time_ikindi.Text = "dd.mm.yyy hh.mm";
            // 
            // lbl_time_ogle
            // 
            this.lbl_time_ogle.AutoSize = true;
            this.lbl_time_ogle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time_ogle.Location = new System.Drawing.Point(326, 66);
            this.lbl_time_ogle.Name = "lbl_time_ogle";
            this.lbl_time_ogle.Size = new System.Drawing.Size(108, 16);
            this.lbl_time_ogle.TabIndex = 15;
            this.lbl_time_ogle.Text = "dd.mm.yyy hh.mm";
            // 
            // lbl_time_sabah
            // 
            this.lbl_time_sabah.AutoSize = true;
            this.lbl_time_sabah.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time_sabah.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_time_sabah.Location = new System.Drawing.Point(326, 33);
            this.lbl_time_sabah.Name = "lbl_time_sabah";
            this.lbl_time_sabah.Size = new System.Drawing.Size(108, 16);
            this.lbl_time_sabah.TabIndex = 14;
            this.lbl_time_sabah.Text = "dd.mm.yyy hh.mm";
            // 
            // nud_oruc
            // 
            this.nud_oruc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.nud_oruc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_oruc.ForeColor = System.Drawing.Color.GreenYellow;
            this.nud_oruc.Location = new System.Drawing.Point(151, 225);
            this.nud_oruc.Maximum = new decimal(new int[] {
            37000,
            0,
            0,
            0});
            this.nud_oruc.Name = "nud_oruc";
            this.nud_oruc.Size = new System.Drawing.Size(169, 27);
            this.nud_oruc.TabIndex = 12;
            this.nud_oruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_oruc.ValueChanged += new System.EventHandler(this.nud_oruc_ValueChanged);
            // 
            // lbl_oruc_title
            // 
            this.lbl_oruc_title.AutoSize = true;
            this.lbl_oruc_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_oruc_title.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_oruc_title.Location = new System.Drawing.Point(6, 231);
            this.lbl_oruc_title.Name = "lbl_oruc_title";
            this.lbl_oruc_title.Size = new System.Drawing.Size(53, 21);
            this.lbl_oruc_title.TabIndex = 13;
            this.lbl_oruc_title.Text = "Oruç:";
            // 
            // nud_vitr
            // 
            this.nud_vitr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.nud_vitr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_vitr.ForeColor = System.Drawing.Color.White;
            this.nud_vitr.Location = new System.Drawing.Point(151, 192);
            this.nud_vitr.Maximum = new decimal(new int[] {
            37000,
            0,
            0,
            0});
            this.nud_vitr.Name = "nud_vitr";
            this.nud_vitr.Size = new System.Drawing.Size(169, 27);
            this.nud_vitr.TabIndex = 10;
            this.nud_vitr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_vitr.ValueChanged += new System.EventHandler(this.nud_vitr_ValueChanged);
            // 
            // lbl_vitr_title
            // 
            this.lbl_vitr_title.AutoSize = true;
            this.lbl_vitr_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vitr_title.Location = new System.Drawing.Point(6, 198);
            this.lbl_vitr_title.Name = "lbl_vitr_title";
            this.lbl_vitr_title.Size = new System.Drawing.Size(101, 21);
            this.lbl_vitr_title.TabIndex = 11;
            this.lbl_vitr_title.Text = "Vitr namazı:";
            // 
            // nud_yatsi
            // 
            this.nud_yatsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.nud_yatsi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_yatsi.ForeColor = System.Drawing.Color.GreenYellow;
            this.nud_yatsi.Location = new System.Drawing.Point(151, 159);
            this.nud_yatsi.Maximum = new decimal(new int[] {
            37000,
            0,
            0,
            0});
            this.nud_yatsi.Name = "nud_yatsi";
            this.nud_yatsi.Size = new System.Drawing.Size(169, 27);
            this.nud_yatsi.TabIndex = 8;
            this.nud_yatsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_yatsi.ValueChanged += new System.EventHandler(this.nud_yatsi_ValueChanged);
            // 
            // lbl_yatsi_title
            // 
            this.lbl_yatsi_title.AutoSize = true;
            this.lbl_yatsi_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.lbl_yatsi_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yatsi_title.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_yatsi_title.Location = new System.Drawing.Point(6, 165);
            this.lbl_yatsi_title.Name = "lbl_yatsi_title";
            this.lbl_yatsi_title.Size = new System.Drawing.Size(113, 21);
            this.lbl_yatsi_title.TabIndex = 9;
            this.lbl_yatsi_title.Text = "Yatsı namazı:";
            // 
            // nud_aksam
            // 
            this.nud_aksam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.nud_aksam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_aksam.ForeColor = System.Drawing.Color.White;
            this.nud_aksam.Location = new System.Drawing.Point(151, 126);
            this.nud_aksam.Maximum = new decimal(new int[] {
            37000,
            0,
            0,
            0});
            this.nud_aksam.Name = "nud_aksam";
            this.nud_aksam.Size = new System.Drawing.Size(169, 27);
            this.nud_aksam.TabIndex = 6;
            this.nud_aksam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_aksam.ValueChanged += new System.EventHandler(this.nud_aksam_ValueChanged);
            // 
            // lbl_aksam_title
            // 
            this.lbl_aksam_title.AutoSize = true;
            this.lbl_aksam_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aksam_title.Location = new System.Drawing.Point(6, 132);
            this.lbl_aksam_title.Name = "lbl_aksam_title";
            this.lbl_aksam_title.Size = new System.Drawing.Size(128, 21);
            this.lbl_aksam_title.TabIndex = 7;
            this.lbl_aksam_title.Text = "Akşam namazı:";
            // 
            // nud_ikindi
            // 
            this.nud_ikindi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.nud_ikindi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_ikindi.ForeColor = System.Drawing.Color.GreenYellow;
            this.nud_ikindi.Location = new System.Drawing.Point(151, 93);
            this.nud_ikindi.Maximum = new decimal(new int[] {
            37000,
            0,
            0,
            0});
            this.nud_ikindi.Name = "nud_ikindi";
            this.nud_ikindi.Size = new System.Drawing.Size(169, 27);
            this.nud_ikindi.TabIndex = 4;
            this.nud_ikindi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_ikindi.ValueChanged += new System.EventHandler(this.nud_ikindi_ValueChanged);
            // 
            // lbl_ikindi_title
            // 
            this.lbl_ikindi_title.AutoSize = true;
            this.lbl_ikindi_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.lbl_ikindi_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ikindi_title.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_ikindi_title.Location = new System.Drawing.Point(8, 99);
            this.lbl_ikindi_title.Name = "lbl_ikindi_title";
            this.lbl_ikindi_title.Size = new System.Drawing.Size(115, 21);
            this.lbl_ikindi_title.TabIndex = 5;
            this.lbl_ikindi_title.Text = "İkindi namazı:";
            // 
            // nud_ogle
            // 
            this.nud_ogle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.nud_ogle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_ogle.ForeColor = System.Drawing.Color.White;
            this.nud_ogle.Location = new System.Drawing.Point(151, 60);
            this.nud_ogle.Maximum = new decimal(new int[] {
            37000,
            0,
            0,
            0});
            this.nud_ogle.Name = "nud_ogle";
            this.nud_ogle.Size = new System.Drawing.Size(169, 27);
            this.nud_ogle.TabIndex = 2;
            this.nud_ogle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_ogle.ValueChanged += new System.EventHandler(this.nud_ogle_ValueChanged);
            // 
            // lbl_ogle_title
            // 
            this.lbl_ogle_title.AutoSize = true;
            this.lbl_ogle_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogle_title.Location = new System.Drawing.Point(6, 66);
            this.lbl_ogle_title.Name = "lbl_ogle_title";
            this.lbl_ogle_title.Size = new System.Drawing.Size(113, 21);
            this.lbl_ogle_title.TabIndex = 3;
            this.lbl_ogle_title.Text = "Öğle namazı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_aktar);
            this.groupBox2.Controls.Add(this.btn_hesapla);
            this.groupBox2.Controls.Add(this.lbl_hesapsonucu);
            this.groupBox2.Controls.Add(this.nud_yilsayisi);
            this.groupBox2.Controls.Add(this.lbl_kilinmayanyil);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kaza Namazı Hesapla";
            // 
            // btn_aktar
            // 
            this.btn_aktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aktar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aktar.Location = new System.Drawing.Point(12, 142);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(438, 27);
            this.btn_aktar.TabIndex = 17;
            this.btn_aktar.Text = "Hesaplama sonucunu kazalarıma aktar";
            this.btn_aktar.UseVisualStyleBackColor = true;
            this.btn_aktar.Visible = false;
            this.btn_aktar.Click += new System.EventHandler(this.btn_aktar_Click);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hesapla.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Location = new System.Drawing.Point(355, 30);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(95, 27);
            this.btn_hesapla.TabIndex = 16;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_hesapsonucu
            // 
            this.lbl_hesapsonucu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hesapsonucu.Location = new System.Drawing.Point(6, 70);
            this.lbl_hesapsonucu.Name = "lbl_hesapsonucu";
            this.lbl_hesapsonucu.Size = new System.Drawing.Size(448, 69);
            this.lbl_hesapsonucu.TabIndex = 15;
            this.lbl_hesapsonucu.Text = "-\r\n-\r\n-\r\n";
            // 
            // nud_yilsayisi
            // 
            this.nud_yilsayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.nud_yilsayisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_yilsayisi.ForeColor = System.Drawing.Color.White;
            this.nud_yilsayisi.Location = new System.Drawing.Point(237, 30);
            this.nud_yilsayisi.Name = "nud_yilsayisi";
            this.nud_yilsayisi.Size = new System.Drawing.Size(107, 27);
            this.nud_yilsayisi.TabIndex = 14;
            this.nud_yilsayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_kilinmayanyil
            // 
            this.lbl_kilinmayanyil.AutoSize = true;
            this.lbl_kilinmayanyil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kilinmayanyil.Location = new System.Drawing.Point(8, 36);
            this.lbl_kilinmayanyil.Name = "lbl_kilinmayanyil";
            this.lbl_kilinmayanyil.Size = new System.Drawing.Size(219, 21);
            this.lbl_kilinmayanyil.TabIndex = 14;
            this.lbl_kilinmayanyil.Text = "Namaz Kılınmayan Yıl sayısı:";
            // 
            // KazaTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(484, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 530);
            this.MinimumSize = new System.Drawing.Size(500, 530);
            this.Name = "KazaTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KazaTakip";
            this.Load += new System.EventHandler(this.KazaTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_sabah)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_oruc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vitr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_yatsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aksam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ikindi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ogle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_yilsayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_sabah;
        private System.Windows.Forms.Label lbl_sabah_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_oruc;
        private System.Windows.Forms.Label lbl_oruc_title;
        private System.Windows.Forms.NumericUpDown nud_vitr;
        private System.Windows.Forms.Label lbl_vitr_title;
        private System.Windows.Forms.NumericUpDown nud_yatsi;
        private System.Windows.Forms.Label lbl_yatsi_title;
        private System.Windows.Forms.NumericUpDown nud_aksam;
        private System.Windows.Forms.Label lbl_aksam_title;
        private System.Windows.Forms.NumericUpDown nud_ikindi;
        private System.Windows.Forms.Label lbl_ikindi_title;
        private System.Windows.Forms.NumericUpDown nud_ogle;
        private System.Windows.Forms.Label lbl_ogle_title;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nud_yilsayisi;
        private System.Windows.Forms.Label lbl_kilinmayanyil;
        private System.Windows.Forms.Label lbl_time_oruc;
        private System.Windows.Forms.Label lbl_time_vitr;
        private System.Windows.Forms.Label lbl_time_yatsi;
        private System.Windows.Forms.Label lbl_time_aksam;
        private System.Windows.Forms.Label lbl_time_ikindi;
        private System.Windows.Forms.Label lbl_time_ogle;
        private System.Windows.Forms.Label lbl_time_sabah;
        private System.Windows.Forms.Button btn_aktar;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_hesapsonucu;
        private System.Windows.Forms.Label label1;
    }
}