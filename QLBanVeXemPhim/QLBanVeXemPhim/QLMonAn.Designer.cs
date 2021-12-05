namespace QLBanVeXemPhim
{
    partial class QLMonAn
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
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLMonAn = new System.Windows.Forms.Button();
            this.btnQLPhim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(106, 67);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(212, 23);
            this.txtTenMon.TabIndex = 35;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(339, 65);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(70, 25);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(88, 535);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 36);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 535);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 36);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(164, 535);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 36);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên món ăn:";
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Location = new System.Drawing.Point(12, 98);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.Size = new System.Drawing.Size(926, 423);
            this.dgvMonAn.TabIndex = 29;
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Location = new System.Drawing.Point(12, 12);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(102, 36);
            this.btnQLNhanVien.TabIndex = 28;
            this.btnQLNhanVien.Text = "Quản lý nhân viên";
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnQLMonAn
            // 
            this.btnQLMonAn.Location = new System.Drawing.Point(211, 12);
            this.btnQLMonAn.Name = "btnQLMonAn";
            this.btnQLMonAn.Size = new System.Drawing.Size(89, 36);
            this.btnQLMonAn.TabIndex = 27;
            this.btnQLMonAn.Text = "Quản lý món ăn";
            this.btnQLMonAn.UseVisualStyleBackColor = true;
            // 
            // btnQLPhim
            // 
            this.btnQLPhim.Location = new System.Drawing.Point(120, 12);
            this.btnQLPhim.Name = "btnQLPhim";
            this.btnQLPhim.Size = new System.Drawing.Size(85, 36);
            this.btnQLPhim.TabIndex = 26;
            this.btnQLPhim.Text = "Quản lý phim";
            this.btnQLPhim.UseVisualStyleBackColor = true;
            // 
            // QLMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 583);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.btnQLNhanVien);
            this.Controls.Add(this.btnQLMonAn);
            this.Controls.Add(this.btnQLPhim);
            this.Name = "QLMonAn";
            this.Text = "QLMonAn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnQLMonAn;
        private System.Windows.Forms.Button btnQLPhim;
    }
}