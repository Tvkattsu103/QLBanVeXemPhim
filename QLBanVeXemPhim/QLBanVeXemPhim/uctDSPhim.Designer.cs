namespace QLBanVeXemPhim
{
    partial class uctDSPhim
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxAnhPhim = new System.Windows.Forms.PictureBox();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpDSThoiGian = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnhPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAnhPhim
            // 
            this.pbxAnhPhim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbxAnhPhim.Location = new System.Drawing.Point(12, 12);
            this.pbxAnhPhim.Name = "pbxAnhPhim";
            this.pbxAnhPhim.Size = new System.Drawing.Size(106, 117);
            this.pbxAnhPhim.TabIndex = 0;
            this.pbxAnhPhim.TabStop = false;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoEllipsis = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhim.Location = new System.Drawing.Point(124, 12);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(217, 21);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "Spider Man: No Way Home";
            this.lblTenPhim.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(127, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 5);
            this.panel1.TabIndex = 2;
            // 
            // flpDSThoiGian
            // 
            this.flpDSThoiGian.Location = new System.Drawing.Point(127, 47);
            this.flpDSThoiGian.Name = "flpDSThoiGian";
            this.flpDSThoiGian.Size = new System.Drawing.Size(344, 82);
            this.flpDSThoiGian.TabIndex = 3;
            // 
            // uctDSPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.flpDSThoiGian);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTenPhim);
            this.Controls.Add(this.pbxAnhPhim);
            this.Name = "uctDSPhim";
            this.Size = new System.Drawing.Size(484, 145);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnhPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAnhPhim;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpDSThoiGian;
    }
}
