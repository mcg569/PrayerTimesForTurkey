namespace MuslimWidget
{
    partial class FormZikirmatik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZikirmatik));
            this.pbx_zikirmatik = new System.Windows.Forms.PictureBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_value = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_zikirmatik)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_zikirmatik
            // 
            this.pbx_zikirmatik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_zikirmatik.BackColor = System.Drawing.Color.White;
            this.pbx_zikirmatik.BackgroundImage = global::MuslimWidget.Properties.Resources.zikirmatik1;
            this.pbx_zikirmatik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_zikirmatik.Location = new System.Drawing.Point(40, 40);
            this.pbx_zikirmatik.Name = "pbx_zikirmatik";
            this.pbx_zikirmatik.Size = new System.Drawing.Size(350, 350);
            this.pbx_zikirmatik.TabIndex = 0;
            this.pbx_zikirmatik.TabStop = false;
            // 
            // btn_plus
            // 
            this.btn_plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btn_plus.BackgroundImage = global::MuslimWidget.Properties.Resources.btn_circ;
            this.btn_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btn_plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Location = new System.Drawing.Point(177, 240);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 75);
            this.btn_plus.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_plus, "ARTIR");
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btn_reset.BackgroundImage = global::MuslimWidget.Properties.Resources.btn_circ;
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(250, 220);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(20, 20);
            this.btn_reset.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_reset, "SIFIRLA");
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_value
            // 
            this.lbl_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(192)))), ((int)(((byte)(106)))));
            this.lbl_value.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_value.ForeColor = System.Drawing.Color.Black;
            this.lbl_value.Location = new System.Drawing.Point(145, 120);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(140, 50);
            this.lbl_value.TabIndex = 3;
            this.lbl_value.Text = "00000";
            this.lbl_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // Zikirmatik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.pbx_zikirmatik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Zikirmatik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zikirmatik";
            this.Load += new System.EventHandler(this.Zikirmatik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_zikirmatik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_zikirmatik;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}