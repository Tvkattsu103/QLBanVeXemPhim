namespace QLBanVeXemPhim
{
    partial class frmQLPhim
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
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLMonAn = new System.Windows.Forms.Button();
            this.btnQLPhim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(89, 66);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(212, 23);
            this.txtTenPhim.TabIndex = 25;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(321, 67);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(70, 25);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(88, 535);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 36);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 535);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 36);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(164, 535);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 36);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên phim:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(926, 423);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Location = new System.Drawing.Point(12, 12);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(102, 36);
            this.btnQLNhanVien.TabIndex = 18;
            this.btnQLNhanVien.Text = "Quản lý nhân viên";
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnQLMonAn
            // 
            this.btnQLMonAn.Location = new System.Drawing.Point(211, 12);
            this.btnQLMonAn.Name = "btnQLMonAn";
            this.btnQLMonAn.Size = new System.Drawing.Size(89, 36);
            this.btnQLMonAn.TabIndex = 17;
            this.btnQLMonAn.Text = "Quản lý món ăn";
            this.btnQLMonAn.UseVisualStyleBackColor = true;
            // 
            // btnQLPhim
            // 
            this.btnQLPhim.Location = new System.Drawing.Point(120, 12);
            this.btnQLPhim.Name = "btnQLPhim";
            this.btnQLPhim.Size = new System.Drawing.Size(85, 36);
            this.btnQLPhim.TabIndex = 16;
            this.btnQLPhim.Text = "Quản lý phim";
            this.btnQLPhim.UseVisualStyleBackColor = true;
            // 
            // frmQLPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 583);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQLNhanVien);
            this.Controls.Add(this.btnQLMonAn);
            this.Controls.Add(this.btnQLPhim);
            this.Name = "frmQLPhim";
            this.Text = "frmQLPhim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnQLMonAn;
        private System.Windows.Forms.Button btnQLPhim;
    }
}