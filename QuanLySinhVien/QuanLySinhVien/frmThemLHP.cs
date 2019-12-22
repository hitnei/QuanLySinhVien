using QuanLySinhVien.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmThemLHP : Form
    {
        private string maMonHoc;

        public frmThemLHP()
        {
            InitializeComponent();
        }

        public frmThemLHP(string maMonHoc)
        {
            InitializeComponent();
            this.maMonHoc = maMonHoc;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemLHP_Click(object sender, EventArgs e)
        {
            LHP lophocphan = new LHP { 
                idLHP = txtMaLHP.Text, 
                DinhMucSinhVien = txtDinhMucSinhVien.Text, 
                GiaoVienPhuTrach = txtGiaoVienPhuTrach.Text, 
                SoLuongSinhVien = txtSoLuongSinhVien.Text, 
                tenLHP = txtTenLHP.Text, 
                idMH = this.maMonHoc
            };
            LHP.themLHP(lophocphan);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
