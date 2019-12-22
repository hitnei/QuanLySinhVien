namespace QuanLySinhVien
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLHP = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSuaLHP = new System.Windows.Forms.ToolStripButton();
            this.btnThemLHP = new System.Windows.Forms.ToolStripButton();
            this.btnXoaLHP = new System.Windows.Forms.ToolStripButton();
            this.lopHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLHP = new System.Windows.Forms.Label();
            this.txtDinhMucSinhVien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongSV = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaoVienPhuTrach = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSuaSV = new System.Windows.Forms.ToolStripButton();
            this.btnDangKySV = new System.Windows.Forms.ToolStripButton();
            this.btnXoaSV = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHP)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn môn học:";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(110, 9);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(197, 21);
            this.cmbMonHoc.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLHP);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 510);
            this.panel1.TabIndex = 2;
            // 
            // dgvLHP
            // 
            this.dgvLHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lopHocPhan});
            this.dgvLHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLHP.Location = new System.Drawing.Point(0, 25);
            this.dgvLHP.Name = "dgvLHP";
            this.dgvLHP.Size = new System.Drawing.Size(295, 485);
            this.dgvLHP.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoaLHP,
            this.btnThemLHP,
            this.btnSuaLHP});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(295, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "Lớp học phần";
            // 
            // btnSuaLHP
            // 
            this.btnSuaLHP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaLHP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLHP.Image")));
            this.btnSuaLHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaLHP.Name = "btnSuaLHP";
            this.btnSuaLHP.Size = new System.Drawing.Size(46, 22);
            this.btnSuaLHP.Text = "Sửa";
            // 
            // btnThemLHP
            // 
            this.btnThemLHP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemLHP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLHP.Image")));
            this.btnThemLHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLHP.Name = "btnThemLHP";
            this.btnThemLHP.Size = new System.Drawing.Size(57, 22);
            this.btnThemLHP.Text = "Thêm";
            // 
            // btnXoaLHP
            // 
            this.btnXoaLHP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaLHP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLHP.Image")));
            this.btnXoaLHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLHP.Name = "btnXoaLHP";
            this.btnXoaLHP.Size = new System.Drawing.Size(47, 22);
            this.btnXoaLHP.Text = "Xóa";
            this.btnXoaLHP.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // lopHocPhan
            // 
            this.lopHocPhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lopHocPhan.HeaderText = "Tên lớp học phần";
            this.lopHocPhan.Name = "lopHocPhan";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtGiaoVienPhuTrach);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSoLuongSV);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDinhMucSinhVien);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMaLHP);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(332, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 100);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp học phần:";
            // 
            // txtMaLHP
            // 
            this.txtMaLHP.AutoSize = true;
            this.txtMaLHP.Location = new System.Drawing.Point(182, 12);
            this.txtMaLHP.Name = "txtMaLHP";
            this.txtMaLHP.Size = new System.Drawing.Size(0, 13);
            this.txtMaLHP.TabIndex = 1;
            this.txtMaLHP.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDinhMucSinhVien
            // 
            this.txtDinhMucSinhVien.AutoSize = true;
            this.txtDinhMucSinhVien.Location = new System.Drawing.Point(182, 41);
            this.txtDinhMucSinhVien.Name = "txtDinhMucSinhVien";
            this.txtDinhMucSinhVien.Size = new System.Drawing.Size(0, 13);
            this.txtDinhMucSinhVien.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Định mức sinh viên:";
            // 
            // txtSoLuongSV
            // 
            this.txtSoLuongSV.AutoSize = true;
            this.txtSoLuongSV.Location = new System.Drawing.Point(182, 73);
            this.txtSoLuongSV.Name = "txtSoLuongSV";
            this.txtSoLuongSV.Size = new System.Drawing.Size(0, 13);
            this.txtSoLuongSV.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số lượng sinh viên đăng ký:";
            // 
            // txtGiaoVienPhuTrach
            // 
            this.txtGiaoVienPhuTrach.AutoSize = true;
            this.txtGiaoVienPhuTrach.Location = new System.Drawing.Point(442, 12);
            this.txtGiaoVienPhuTrach.Name = "txtGiaoVienPhuTrach";
            this.txtGiaoVienPhuTrach.Size = new System.Drawing.Size(0, 13);
            this.txtGiaoVienPhuTrach.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Giáo viên phụ trách:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.toolStrip2);
            this.panel3.Location = new System.Drawing.Point(332, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 372);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVien,
            this.hoDem,
            this.ten,
            this.ngaySinh,
            this.queQuan});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(559, 347);
            this.dataGridView2.TabIndex = 0;
            // 
            // maSinhVien
            // 
            this.maSinhVien.HeaderText = "Mã sinh viên";
            this.maSinhVien.Name = "maSinhVien";
            // 
            // hoDem
            // 
            this.hoDem.HeaderText = "Họ đệm";
            this.hoDem.Name = "hoDem";
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            // 
            // ngaySinh
            // 
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            // 
            // queQuan
            // 
            this.queQuan.HeaderText = "Quê quán";
            this.queQuan.Name = "queQuan";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnXoaSV,
            this.btnDangKySV,
            this.btnSuaSV});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(559, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel2.Text = "Danh sách sinh viên";
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaSV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSV.Image")));
            this.btnSuaSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(46, 22);
            this.btnSuaSV.Text = "Sửa";
            // 
            // btnDangKySV
            // 
            this.btnDangKySV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDangKySV.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKySV.Image")));
            this.btnDangKySV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDangKySV.Name = "btnDangKySV";
            this.btnDangKySV.Size = new System.Drawing.Size(112, 22);
            this.btnDangKySV.Text = "Đăng ký vào lớp";
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaSV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSV.Image")));
            this.btnXoaSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(47, 22);
            this.btnXoaSV.Text = "Xóa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 573);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHP)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopHocPhan;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnXoaLHP;
        private System.Windows.Forms.ToolStripButton btnThemLHP;
        private System.Windows.Forms.ToolStripButton btnSuaLHP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtMaLHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtDinhMucSinhVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtGiaoVienPhuTrach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtSoLuongSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuan;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnXoaSV;
        private System.Windows.Forms.ToolStripButton btnDangKySV;
        private System.Windows.Forms.ToolStripButton btnSuaSV;
    }
}

