namespace MuslimWidget
{
    partial class FormWallpaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWallpaper));
            this.wb_wallpaper = new Gecko.GeckoWebBrowser();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lbl_info = new System.Windows.Forms.Label();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb_wallpaper
            // 
            this.wb_wallpaper.FrameEventsPropagateToMainWindow = false;
            this.wb_wallpaper.Location = new System.Drawing.Point(12, 12);
            this.wb_wallpaper.Name = "wb_wallpaper";
            this.wb_wallpaper.Size = new System.Drawing.Size(18, 16);
            this.wb_wallpaper.TabIndex = 0;
            this.wb_wallpaper.UseHttpActivityObserver = false;
            this.wb_wallpaper.Visible = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lbl_info);
            this.pnlTop.Location = new System.Drawing.Point(12, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(719, 40);
            this.pnlTop.TabIndex = 1;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbl_info.Location = new System.Drawing.Point(11, 11);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(14, 18);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "-";
            // 
            // flpMain
            // 
            this.flpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMain.AutoScroll = true;
            this.flpMain.Location = new System.Drawing.Point(12, 64);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(719, 445);
            this.flpMain.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // Wallpaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(743, 521);
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.wb_wallpaper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(590, 560);
            this.Name = "Wallpaper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İslami Duvar Kağıtları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Wallpaper_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gecko.GeckoWebBrowser wb_wallpaper;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_info;
    }
}