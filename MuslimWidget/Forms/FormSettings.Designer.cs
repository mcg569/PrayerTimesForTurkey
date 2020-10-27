namespace MuslimWidget
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.cbx_minimize = new System.Windows.Forms.CheckBox();
            this.nud_kerahat = new System.Windows.Forms.NumericUpDown();
            this.lbl_kerahat = new System.Windows.Forms.Label();
            this.pnlKerahat = new System.Windows.Forms.Panel();
            this.question_kerahat = new System.Windows.Forms.Label();
            this.pnlAlarm = new System.Windows.Forms.Panel();
            this.question_alarm = new System.Windows.Forms.Label();
            this.lbl_alarm = new System.Windows.Forms.Label();
            this.nud_alarm = new System.Windows.Forms.NumericUpDown();
            this.pnlMinimize = new System.Windows.Forms.Panel();
            this.question_minimize = new System.Windows.Forms.Label();
            this.pnlResources = new System.Windows.Forms.Panel();
            this.lbl_resources = new System.Windows.Forms.Label();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.lbl_about = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kerahat)).BeginInit();
            this.pnlKerahat.SuspendLayout();
            this.pnlAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_alarm)).BeginInit();
            this.pnlMinimize.SuspendLayout();
            this.pnlResources.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_minimize
            // 
            this.cbx_minimize.AutoSize = true;
            this.cbx_minimize.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_minimize.ForeColor = System.Drawing.Color.White;
            this.cbx_minimize.Location = new System.Drawing.Point(10, 8);
            this.cbx_minimize.Name = "cbx_minimize";
            this.cbx_minimize.Size = new System.Drawing.Size(307, 22);
            this.cbx_minimize.TabIndex = 0;
            this.cbx_minimize.Text = "Kapatıldığında görev çubuğuna küçült";
            this.cbx_minimize.UseVisualStyleBackColor = true;
            this.cbx_minimize.CheckedChanged += new System.EventHandler(this.cbx_minimize_CheckedChanged);
            // 
            // nud_kerahat
            // 
            this.nud_kerahat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_kerahat.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_kerahat.Location = new System.Drawing.Point(297, 6);
            this.nud_kerahat.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_kerahat.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nud_kerahat.Name = "nud_kerahat";
            this.nud_kerahat.Size = new System.Drawing.Size(109, 27);
            this.nud_kerahat.TabIndex = 1;
            this.nud_kerahat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_kerahat.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nud_kerahat.ValueChanged += new System.EventHandler(this.nud_kerahat_ValueChanged);
            // 
            // lbl_kerahat
            // 
            this.lbl_kerahat.AutoSize = true;
            this.lbl_kerahat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kerahat.ForeColor = System.Drawing.Color.White;
            this.lbl_kerahat.Location = new System.Drawing.Point(10, 10);
            this.lbl_kerahat.Name = "lbl_kerahat";
            this.lbl_kerahat.Size = new System.Drawing.Size(182, 18);
            this.lbl_kerahat.TabIndex = 2;
            this.lbl_kerahat.Text = "Kerahat vakti (dakika):";
            // 
            // pnlKerahat
            // 
            this.pnlKerahat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKerahat.Controls.Add(this.question_kerahat);
            this.pnlKerahat.Controls.Add(this.lbl_kerahat);
            this.pnlKerahat.Controls.Add(this.nud_kerahat);
            this.pnlKerahat.Location = new System.Drawing.Point(12, 14);
            this.pnlKerahat.Name = "pnlKerahat";
            this.pnlKerahat.Size = new System.Drawing.Size(450, 40);
            this.pnlKerahat.TabIndex = 3;
            // 
            // question_kerahat
            // 
            this.question_kerahat.AutoSize = true;
            this.question_kerahat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.question_kerahat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.question_kerahat.ForeColor = System.Drawing.Color.White;
            this.question_kerahat.Location = new System.Drawing.Point(414, 10);
            this.question_kerahat.Name = "question_kerahat";
            this.question_kerahat.Size = new System.Drawing.Size(31, 18);
            this.question_kerahat.TabIndex = 3;
            this.question_kerahat.Text = "(?)";
            this.question_kerahat.Click += new System.EventHandler(this.question_kerahat_Click);
            // 
            // pnlAlarm
            // 
            this.pnlAlarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlarm.Controls.Add(this.question_alarm);
            this.pnlAlarm.Controls.Add(this.lbl_alarm);
            this.pnlAlarm.Controls.Add(this.nud_alarm);
            this.pnlAlarm.Location = new System.Drawing.Point(12, 60);
            this.pnlAlarm.Name = "pnlAlarm";
            this.pnlAlarm.Size = new System.Drawing.Size(450, 40);
            this.pnlAlarm.TabIndex = 4;
            // 
            // question_alarm
            // 
            this.question_alarm.AutoSize = true;
            this.question_alarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.question_alarm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.question_alarm.ForeColor = System.Drawing.Color.White;
            this.question_alarm.Location = new System.Drawing.Point(414, 10);
            this.question_alarm.Name = "question_alarm";
            this.question_alarm.Size = new System.Drawing.Size(31, 18);
            this.question_alarm.TabIndex = 3;
            this.question_alarm.Text = "(?)";
            this.question_alarm.Click += new System.EventHandler(this.question_alarm_Click);
            // 
            // lbl_alarm
            // 
            this.lbl_alarm.AutoSize = true;
            this.lbl_alarm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alarm.ForeColor = System.Drawing.Color.White;
            this.lbl_alarm.Location = new System.Drawing.Point(10, 10);
            this.lbl_alarm.Name = "lbl_alarm";
            this.lbl_alarm.Size = new System.Drawing.Size(271, 18);
            this.lbl_alarm.TabIndex = 2;
            this.lbl_alarm.Text = "Ezan vaktinden önce uyar (dakika):";
            // 
            // nud_alarm
            // 
            this.nud_alarm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_alarm.Location = new System.Drawing.Point(297, 6);
            this.nud_alarm.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nud_alarm.Name = "nud_alarm";
            this.nud_alarm.Size = new System.Drawing.Size(109, 27);
            this.nud_alarm.TabIndex = 1;
            this.nud_alarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_alarm.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_alarm.ValueChanged += new System.EventHandler(this.nud_alarm_ValueChanged);
            // 
            // pnlMinimize
            // 
            this.pnlMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMinimize.Controls.Add(this.question_minimize);
            this.pnlMinimize.Controls.Add(this.cbx_minimize);
            this.pnlMinimize.Location = new System.Drawing.Point(12, 106);
            this.pnlMinimize.Name = "pnlMinimize";
            this.pnlMinimize.Size = new System.Drawing.Size(450, 40);
            this.pnlMinimize.TabIndex = 5;
            // 
            // question_minimize
            // 
            this.question_minimize.AutoSize = true;
            this.question_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.question_minimize.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.question_minimize.ForeColor = System.Drawing.Color.White;
            this.question_minimize.Location = new System.Drawing.Point(414, 10);
            this.question_minimize.Name = "question_minimize";
            this.question_minimize.Size = new System.Drawing.Size(31, 18);
            this.question_minimize.TabIndex = 4;
            this.question_minimize.Text = "(?)";
            this.question_minimize.Click += new System.EventHandler(this.question_minimize_Click);
            // 
            // pnlResources
            // 
            this.pnlResources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResources.Controls.Add(this.lbl_resources);
            this.pnlResources.Location = new System.Drawing.Point(12, 152);
            this.pnlResources.Name = "pnlResources";
            this.pnlResources.Size = new System.Drawing.Size(450, 124);
            this.pnlResources.TabIndex = 6;
            // 
            // lbl_resources
            // 
            this.lbl_resources.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_resources.ForeColor = System.Drawing.Color.White;
            this.lbl_resources.Location = new System.Drawing.Point(6, 7);
            this.lbl_resources.Name = "lbl_resources";
            this.lbl_resources.Size = new System.Drawing.Size(439, 109);
            this.lbl_resources.TabIndex = 4;
            this.lbl_resources.Text = "KAYNAKLAR:\r\nNamaz Vakitleri: www.sabah.com.tr/namaz-vakitleri\r\nKur\'an-ı Kerim Tür" +
    "kçe Meâli: www.kuranikerim.com/m_diyanet_index.htm\r\nDuvar kağıtları: www.islamid" +
    "uvarkagitlari.blogspot.com";
            // 
            // pnlAbout
            // 
            this.pnlAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAbout.Controls.Add(this.lbl_about);
            this.pnlAbout.Location = new System.Drawing.Point(12, 282);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(450, 117);
            this.pnlAbout.TabIndex = 7;
            // 
            // lbl_about
            // 
            this.lbl_about.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_about.ForeColor = System.Drawing.Color.White;
            this.lbl_about.Location = new System.Drawing.Point(3, 3);
            this.lbl_about.Name = "lbl_about";
            this.lbl_about.Size = new System.Drawing.Size(442, 110);
            this.lbl_about.TabIndex = 4;
            this.lbl_about.Text = "HAKKINDA:\r\nBu program herhangi bir kâr amacı güdülmeden geliştirilmiştir. Açık ka" +
    "ynak kodlu olarak yayınlanmıştır. İsteyen istediği şekilde kullanabilir.\r\nİletiş" +
    "im: can436436@gmail.com";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(474, 411);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.pnlResources);
            this.Controls.Add(this.pnlMinimize);
            this.Controls.Add(this.pnlAlarm);
            this.Controls.Add(this.pnlKerahat);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(490, 450);
            this.MinimumSize = new System.Drawing.Size(480, 450);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            ((System.ComponentModel.ISupportInitialize)(this.nud_kerahat)).EndInit();
            this.pnlKerahat.ResumeLayout(false);
            this.pnlKerahat.PerformLayout();
            this.pnlAlarm.ResumeLayout(false);
            this.pnlAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_alarm)).EndInit();
            this.pnlMinimize.ResumeLayout(false);
            this.pnlMinimize.PerformLayout();
            this.pnlResources.ResumeLayout(false);
            this.pnlAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbx_minimize;
        private System.Windows.Forms.NumericUpDown nud_kerahat;
        private System.Windows.Forms.Label lbl_kerahat;
        private System.Windows.Forms.Panel pnlKerahat;
        private System.Windows.Forms.Label question_kerahat;
        private System.Windows.Forms.Panel pnlAlarm;
        private System.Windows.Forms.Label question_alarm;
        private System.Windows.Forms.Label lbl_alarm;
        private System.Windows.Forms.NumericUpDown nud_alarm;
        private System.Windows.Forms.Panel pnlMinimize;
        private System.Windows.Forms.Label question_minimize;
        private System.Windows.Forms.Panel pnlResources;
        private System.Windows.Forms.Label lbl_resources;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Label lbl_about;
    }
}