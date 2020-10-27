namespace MuslimWidget
{
    partial class NextDayEzan
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_imsak = new System.Windows.Forms.Label();
            this.lbl_gunes = new System.Windows.Forms.Label();
            this.lbl_ogle = new System.Windows.Forms.Label();
            this.lbl_ikindi = new System.Windows.Forms.Label();
            this.lbl_aksam = new System.Windows.Forms.Label();
            this.lbl_yatsi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(15, 11);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(92, 18);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "dd.mm.yyyy";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_imsak
            // 
            this.lbl_imsak.AutoSize = true;
            this.lbl_imsak.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_imsak.ForeColor = System.Drawing.Color.White;
            this.lbl_imsak.Location = new System.Drawing.Point(125, 11);
            this.lbl_imsak.Name = "lbl_imsak";
            this.lbl_imsak.Size = new System.Drawing.Size(45, 18);
            this.lbl_imsak.TabIndex = 1;
            this.lbl_imsak.Text = "00:00";
            this.lbl_imsak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_gunes
            // 
            this.lbl_gunes.AutoSize = true;
            this.lbl_gunes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gunes.ForeColor = System.Drawing.Color.White;
            this.lbl_gunes.Location = new System.Drawing.Point(190, 11);
            this.lbl_gunes.Name = "lbl_gunes";
            this.lbl_gunes.Size = new System.Drawing.Size(45, 18);
            this.lbl_gunes.TabIndex = 2;
            this.lbl_gunes.Text = "00:00";
            this.lbl_gunes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ogle
            // 
            this.lbl_ogle.AutoSize = true;
            this.lbl_ogle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ogle.ForeColor = System.Drawing.Color.White;
            this.lbl_ogle.Location = new System.Drawing.Point(260, 11);
            this.lbl_ogle.Name = "lbl_ogle";
            this.lbl_ogle.Size = new System.Drawing.Size(45, 18);
            this.lbl_ogle.TabIndex = 3;
            this.lbl_ogle.Text = "00:00";
            this.lbl_ogle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ikindi
            // 
            this.lbl_ikindi.AutoSize = true;
            this.lbl_ikindi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ikindi.ForeColor = System.Drawing.Color.White;
            this.lbl_ikindi.Location = new System.Drawing.Point(330, 11);
            this.lbl_ikindi.Name = "lbl_ikindi";
            this.lbl_ikindi.Size = new System.Drawing.Size(45, 18);
            this.lbl_ikindi.TabIndex = 4;
            this.lbl_ikindi.Text = "00:00";
            this.lbl_ikindi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_aksam
            // 
            this.lbl_aksam.AutoSize = true;
            this.lbl_aksam.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aksam.ForeColor = System.Drawing.Color.White;
            this.lbl_aksam.Location = new System.Drawing.Point(400, 11);
            this.lbl_aksam.Name = "lbl_aksam";
            this.lbl_aksam.Size = new System.Drawing.Size(45, 18);
            this.lbl_aksam.TabIndex = 5;
            this.lbl_aksam.Text = "00:00";
            this.lbl_aksam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_yatsi
            // 
            this.lbl_yatsi.AutoSize = true;
            this.lbl_yatsi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yatsi.ForeColor = System.Drawing.Color.White;
            this.lbl_yatsi.Location = new System.Drawing.Point(470, 11);
            this.lbl_yatsi.Name = "lbl_yatsi";
            this.lbl_yatsi.Size = new System.Drawing.Size(45, 18);
            this.lbl_yatsi.TabIndex = 6;
            this.lbl_yatsi.Text = "00:00";
            this.lbl_yatsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextDayEzan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::MuslimWidget.Properties.Resources.top_bar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_yatsi);
            this.Controls.Add(this.lbl_aksam);
            this.Controls.Add(this.lbl_ikindi);
            this.Controls.Add(this.lbl_ogle);
            this.Controls.Add(this.lbl_gunes);
            this.Controls.Add(this.lbl_imsak);
            this.Controls.Add(this.lbl_date);
            this.DoubleBuffered = true;
            this.Name = "NextDayEzan";
            this.Size = new System.Drawing.Size(530, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_imsak;
        private System.Windows.Forms.Label lbl_gunes;
        private System.Windows.Forms.Label lbl_ogle;
        private System.Windows.Forms.Label lbl_ikindi;
        private System.Windows.Forms.Label lbl_aksam;
        private System.Windows.Forms.Label lbl_yatsi;
    }
}
