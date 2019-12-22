namespace QuanLySinhVien
{
    partial class frmXoaLHP
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
            this.btnXoaLHP = new System.Windows.Forms.Button();
            this.btnHuyLHP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác nhận xóa lớp học phần?";
            // 
            // btnXoaLHP
            // 
            this.btnXoaLHP.Location = new System.Drawing.Point(94, 145);
            this.btnXoaLHP.Name = "btnXoaLHP";
            this.btnXoaLHP.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLHP.TabIndex = 1;
            this.btnXoaLHP.Text = "Đồng ý";
            this.btnXoaLHP.UseVisualStyleBackColor = true;
            // 
            // btnHuyLHP
            // 
            this.btnHuyLHP.Location = new System.Drawing.Point(273, 145);
            this.btnHuyLHP.Name = "btnHuyLHP";
            this.btnHuyLHP.Size = new System.Drawing.Size(75, 23);
            this.btnHuyLHP.TabIndex = 2;
            this.btnHuyLHP.Text = "Hủy";
            this.btnHuyLHP.UseVisualStyleBackColor = true;
            // 
            // frmXoaLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 215);
            this.Controls.Add(this.btnHuyLHP);
            this.Controls.Add(this.btnXoaLHP);
            this.Controls.Add(this.label1);
            this.Name = "frmXoaLHP";
            this.Text = "xoaLHP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaLHP;
        private System.Windows.Forms.Button btnHuyLHP;
    }
}