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
    public partial class frmSuaLHP : Form
    {
        LHP lopHocPhan;
        public frmSuaLHP()
        {
            InitializeComponent();
        }
        public frmSuaLHP(LHP lhp)
        {
            InitializeComponent();
            lopHocPhan = lhp;
            txtDinhMucSinhVien.Text = lopHocPhan.DinhMucSinhVien;
            txtTenLHP.Text = lopHocPhan.tenLHP;
            txtSoLuongSinhVien.Text = lopHocPhan.SoLuongSinhVien;
            txtGiaoVienPhuTrach.Text = lopHocPhan.GiaoVienPhuTrach;
        }

        private void btnHuyLHP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaLHP_Click(object sender, EventArgs e)
        {
            LHP lhp = new LHP
            {
                DinhMucSinhVien = txtDinhMucSinhVien.Text,
                idLHP = lopHocPhan.idLHP,
                GiaoVienPhuTrach = txtGiaoVienPhuTrach.Text,
                idMH = lopHocPhan.idMH,
                SoLuongSinhVien = txtSoLuongSinhVien.Text,
                tenLHP = txtTenLHP.Text
            };
            LHP.suaLHP(lhp);
        }
    }
}
