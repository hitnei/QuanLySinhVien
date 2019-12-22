namespace QuanLySinhVien
{
    partial class frmSuaLHP
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
            this.txtGiaoVienPhuTrach = new System.Windows.Forms.TextBox();
            this.txtSoLuongSinhVien = new System.Windows.Forms.TextBox();
            this.txtDinhMucSinhVien = new System.Windows.Forms.TextBox();
            this.txtTenLHP = new System.Windows.Forms.TextBox();
            this.btnHuyLHP = new System.Windows.Forms.Button();
            this.btnSuaLHP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGiaoVienPhuTrach
            // 
            this.txtGiaoVienPhuTrach.Location = new System.Drawing.Point(198, 204);
            this.txtGiaoVienPhuTrach.Name = "txtGiaoVienPhuTrach";
            this.txtGiaoVienPhuTrach.Size = new System.Drawing.Size(260, 20);
            this.txtGiaoVienPhuTrach.TabIndex = 24;
            // 
            // txtSoLuongSinhVien
            // 
            this.txtSoLuongSinhVien.Location = new System.Drawing.Point(198, 151);
            this.txtSoLuongSinhVien.Name = "txtSoLuongSinhVien";
            this.txtSoLuongSinhVien.Size = new System.Drawing.Size(260, 20);
            this.txtSoLuongSinhVien.TabIndex = 23;
            // 
            // txtDinhMucSinhVien
            // 
            this.txtDinhMucSinhVien.Location = new System.Drawing.Point(198, 97);
            this.txtDinhMucSinhVien.Name = "txtDinhMucSinhVien";
            this.txtDinhMucSinhVien.Size = new System.Drawing.Size(260, 20);
            this.txtDinhMucSinhVien.TabIndex = 22;
            // 
            // txtTenLHP
            // 
            this.txtTenLHP.Location = new System.Drawing.Point(198, 53);
            this.txtTenLHP.Name = "txtTenLHP";
            this.txtTenLHP.Size = new System.Drawing.Size(260, 20);
            this.txtTenLHP.TabIndex = 21;
            // 
            // btnHuyLHP
            // 
            this.btnHuyLHP.Location = new System.Drawing.Point(383, 270);
            this.btnHuyLHP.Name = "btnHuyLHP";
            this.btnHuyLHP.Size = new System.Drawing.Size(75, 23);
            this.btnHuyLHP.TabIndex = 19;
            this.btnHuyLHP.Text = "Hủy";
            this.btnHuyLHP.UseVisualStyleBackColor = true;
            this.btnHuyLHP.Click += new System.EventHandler(this.btnHuyLHP_Click);
            // 
            // btnSuaLHP
            // 
            this.btnSuaLHP.Location = new System.Drawing.Point(257, 270);
            this.btnSuaLHP.Name = "btnSuaLHP";
            this.btnSuaLHP.Size = new System.Drawing.Size(75, 23);
            this.btnSuaLHP.TabIndex = 18;
            this.btnSuaLHP.Text = "Sửa";
            this.btnSuaLHP.UseVisualStyleBackColor = true;
            this.btnSuaLHP.Click += new System.EventHandler(this.btnSuaLHP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên lớp học phần:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giáo viên phụ trách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số lượng sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Định mức sinh viên:";
            // 
            // frmSuaLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 334);
            this.Controls.Add(this.txtGiaoVienPhuTrach);
            this.Controls.Add(this.txtSoLuongSinhVien);
            this.Controls.Add(this.txtDinhMucSinhVien);
            this.Controls.Add(this.txtTenLHP);
            this.Controls.Add(this.btnHuyLHP);
            this.Controls.Add(this.btnSuaLHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "frmSuaLHP";
            this.Text = "suaLHP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiaoVienPhuTrach;
        private System.Windows.Forms.TextBox txtSoLuongSinhVien;
        private System.Windows.Forms.TextBox txtDinhMucSinhVien;
        private System.Windows.Forms.TextBox txtTenLHP;
        private System.Windows.Forms.Button btnHuyLHP;
        private System.Windows.Forms.Button btnSuaLHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}