namespace QuanLySinhVien
{
    partial class frmThemLHP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemLHP = new System.Windows.Forms.Button();
            this.btnHuyLHP = new System.Windows.Forms.Button();
            this.txtMaLHP = new System.Windows.Forms.TextBox();
            this.txtTenLHP = new System.Windows.Forms.TextBox();
            this.txtDinhMucSinhVien = new System.Windows.Forms.TextBox();
            this.txtSoLuongSinhVien = new System.Windows.Forms.TextBox();
            this.txtGiaoVienPhuTrach = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp học phần:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Định mức sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên lớp học phần:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giáo viên phụ trách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số lượng sinh viên:";
            // 
            // btnThemLHP
            // 
            this.btnThemLHP.Location = new System.Drawing.Point(247, 314);
            this.btnThemLHP.Name = "btnThemLHP";
            this.btnThemLHP.Size = new System.Drawing.Size(75, 23);
            this.btnThemLHP.TabIndex = 6;
            this.btnThemLHP.Text = "Thêm";
            this.btnThemLHP.UseVisualStyleBackColor = true;
            this.btnThemLHP.Click += new System.EventHandler(this.btnThemLHP_Click);
            // 
            // btnHuyLHP
            // 
            this.btnHuyLHP.Location = new System.Drawing.Point(373, 314);
            this.btnHuyLHP.Name = "btnHuyLHP";
            this.btnHuyLHP.Size = new System.Drawing.Size(75, 23);
            this.btnHuyLHP.TabIndex = 7;
            this.btnHuyLHP.Text = "Hủy";
            this.btnHuyLHP.UseVisualStyleBackColor = true;
            this.btnHuyLHP.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaLHP
            // 
            this.txtMaLHP.Location = new System.Drawing.Point(188, 46);
            this.txtMaLHP.Name = "txtMaLHP";
            this.txtMaLHP.Size = new System.Drawing.Size(260, 20);
            this.txtMaLHP.TabIndex = 8;
            // 
            // txtTenLHP
            // 
            this.txtTenLHP.Location = new System.Drawing.Point(188, 97);
            this.txtTenLHP.Name = "txtTenLHP";
            this.txtTenLHP.Size = new System.Drawing.Size(260, 20);
            this.txtTenLHP.TabIndex = 9;
            // 
            // txtDinhMucSinhVien
            // 
            this.txtDinhMucSinhVien.Location = new System.Drawing.Point(188, 141);
            this.txtDinhMucSinhVien.Name = "txtDinhMucSinhVien";
            this.txtDinhMucSinhVien.Size = new System.Drawing.Size(260, 20);
            this.txtDinhMucSinhVien.TabIndex = 10;
            // 
            // txtSoLuongSinhVien
            // 
            this.txtSoLuongSinhVien.Location = new System.Drawing.Point(188, 195);
            this.txtSoLuongSinhVien.Name = "txtSoLuongSinhVien";
            this.txtSoLuongSinhVien.Size = new System.Drawing.Size(260, 20);
            this.txtSoLuongSinhVien.TabIndex = 11;
            // 
            // txtGiaoVienPhuTrach
            // 
            this.txtGiaoVienPhuTrach.Location = new System.Drawing.Point(188, 248);
            this.txtGiaoVienPhuTrach.Name = "txtGiaoVienPhuTrach";
            this.txtGiaoVienPhuTrach.Size = new System.Drawing.Size(260, 20);
            this.txtGiaoVienPhuTrach.TabIndex = 12;
            // 
            // frmThemLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 380);
            this.Controls.Add(this.txtGiaoVienPhuTrach);
            this.Controls.Add(this.txtSoLuongSinhVien);
            this.Controls.Add(this.txtDinhMucSinhVien);
            this.Controls.Add(this.txtTenLHP);
            this.Controls.Add(this.txtMaLHP);
            this.Controls.Add(this.btnHuyLHP);
            this.Controls.Add(this.btnThemLHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemLHP";
            this.Text = "Thêm lớp học phần";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemLHP;
        private System.Windows.Forms.Button btnHuyLHP;
        private System.Windows.Forms.TextBox txtMaLHP;
        private System.Windows.Forms.TextBox txtTenLHP;
        private System.Windows.Forms.TextBox txtDinhMucSinhVien;
        private System.Windows.Forms.TextBox txtSoLuongSinhVien;
        private System.Windows.Forms.TextBox txtGiaoVienPhuTrach;
    }
}