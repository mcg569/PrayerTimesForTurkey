namespace MuslimWidget
{
    partial class FormReadQuran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReadQuran));
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.cbx_sureler = new System.Windows.Forms.ComboBox();
            this.wb_Kuran1 = new Gecko.GeckoWebBrowser();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Download = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_yaziboyutu = new System.Windows.Forms.NumericUpDown();
            this.cbx_tema = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ptn_update = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_yaziboyutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptn_update)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMain
            // 
            this.rtbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.rtbMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbMain.ForeColor = System.Drawing.Color.White;
            this.rtbMain.Location = new System.Drawing.Point(12, 65);
            this.rtbMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.Size = new System.Drawing.Size(660, 483);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            // 
            // cbx_sureler
            // 
            this.cbx_sureler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sureler.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_sureler.FormattingEnabled = true;
            this.cbx_sureler.Location = new System.Drawing.Point(12, 29);
            this.cbx_sureler.Name = "cbx_sureler";
            this.cbx_sureler.Size = new System.Drawing.Size(145, 24);
            this.cbx_sureler.TabIndex = 1;
            this.cbx_sureler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // wb_Kuran1
            // 
            this.wb_Kuran1.FrameEventsPropagateToMainWindow = false;
            this.wb_Kuran1.Location = new System.Drawing.Point(647, 12);
            this.wb_Kuran1.Name = "wb_Kuran1";
            this.wb_Kuran1.Size = new System.Drawing.Size(25, 25);
            this.wb_Kuran1.TabIndex = 2;
            this.wb_Kuran1.UseHttpActivityObserver = false;
            this.wb_Kuran1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(25, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(348, 15);
            this.progressBar1.TabIndex = 3;
            // 
            // btn_Download
            // 
            this.btn_Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Download.FlatAppearance.BorderSize = 3;
            this.btn_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Download.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Download.ForeColor = System.Drawing.Color.White;
            this.btn_Download.Location = new System.Drawing.Point(75, 87);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(248, 50);
            this.btn_Download.TabIndex = 4;
            this.btn_Download.Text = "İNDİR";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Download);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(130, 153);
            this.panel1.MaximumSize = new System.Drawing.Size(400, 200);
            this.panel1.MinimumSize = new System.Drawing.Size(400, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 200);
            this.panel1.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(362, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "x";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kur\'an-ı Kerim Türkçe meâli bilgisayarınıza indirin.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sureler:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yazı boyutu:";
            // 
            // nud_yaziboyutu
            // 
            this.nud_yaziboyutu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_yaziboyutu.Location = new System.Drawing.Point(178, 28);
            this.nud_yaziboyutu.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nud_yaziboyutu.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_yaziboyutu.Name = "nud_yaziboyutu";
            this.nud_yaziboyutu.Size = new System.Drawing.Size(110, 22);
            this.nud_yaziboyutu.TabIndex = 10;
            this.nud_yaziboyutu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_yaziboyutu.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nud_yaziboyutu.ValueChanged += new System.EventHandler(this.nud_yaziboyutu_ValueChanged);
            // 
            // cbx_tema
            // 
            this.cbx_tema.AutoCompleteCustomSource.AddRange(new string[] {
            "Koyu",
            "Açık",
            "Yeşil",
            "Mavi"});
            this.cbx_tema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tema.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_tema.FormattingEnabled = true;
            this.cbx_tema.Items.AddRange(new object[] {
            "Koyu",
            "Açık",
            "Yeşil",
            "Mavi"});
            this.cbx_tema.Location = new System.Drawing.Point(308, 28);
            this.cbx_tema.Name = "cbx_tema";
            this.cbx_tema.Size = new System.Drawing.Size(109, 24);
            this.cbx_tema.TabIndex = 11;
            this.cbx_tema.SelectedIndexChanged += new System.EventHandler(this.cbx_tema_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(305, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tema:";
            // 
            // ptn_update
            // 
            this.ptn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptn_update.Image = global::MuslimWidget.Properties.Resources.refresh__1_;
            this.ptn_update.Location = new System.Drawing.Point(647, 12);
            this.ptn_update.Name = "ptn_update";
            this.ptn_update.Size = new System.Drawing.Size(25, 25);
            this.ptn_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptn_update.TabIndex = 6;
            this.ptn_update.TabStop = false;
            this.ptn_update.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormReadQuran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_tema);
            this.Controls.Add(this.nud_yaziboyutu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ptn_update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wb_Kuran1);
            this.Controls.Add(this.cbx_sureler);
            this.Controls.Add(this.rtbMain);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormReadQuran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KUR\'AN-I KERİM TÜRKÇE MEÂL OKU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKuranOku_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_yaziboyutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptn_update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.ComboBox cbx_sureler;
        private Gecko.GeckoWebBrowser wb_Kuran1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptn_update;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_yaziboyutu;
        private System.Windows.Forms.ComboBox cbx_tema;
        private System.Windows.Forms.Label label5;
    }
}