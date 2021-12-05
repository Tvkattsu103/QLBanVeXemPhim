namespace QLBanVeXemPhim
{
    partial class uctMonAnTrongDH
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
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblSlMon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(18, 22);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(86, 17);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Bắp rang bơ";
            // 
            // lblSlMon
            // 
            this.lblSlMon.AutoSize = true;
            this.lblSlMon.BackColor = System.Drawing.SystemColors.Window;
            this.lblSlMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlMon.Location = new System.Drawing.Point(185, 22);
            this.lblSlMon.Name = "lblSlMon";
            this.lblSlMon.Size = new System.Drawing.Size(22, 17);
            this.lblSlMon.TabIndex = 1;
            this.lblSlMon.Text = "x1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "50000đ";
            // 
            // uctMonAnTrongDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSlMon);
            this.Controls.Add(this.lblTenMon);
            this.Name = "uctMonAnTrongDH";
            this.Size = new System.Drawing.Size(231, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblSlMon;
        private System.Windows.Forms.Label label1;
    }
}
