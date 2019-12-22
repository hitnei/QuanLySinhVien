using QuanLySinhVien.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        List<MH> lstMH;
        List<LHP> lstLHP;
        List<SV> lstSV;
        int indexLHP;
        int indexMH;
        public Form1()
        {
            InitializeComponent();
            dgvLHP.AutoGenerateColumns = false;
            dgvSV.AutoGenerateColumns = false;
            lstMH = MH.getMH();
            for (int i=0; i<lstMH.Count(); i++)
            {
                cmbMonHoc.Items.Add(lstMH.ElementAt(i).tenMH);
            }
            cmbMonHoc.SelectedIndex = 0;
            //dgvLHP.CurrentRow.Selected = 0;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexMH = cmbMonHoc.SelectedIndex;
            lstLHP = LHP.getLHP(lstMH.ElementAt(indexMH).idMH);
            bdsLHP.DataSource = lstLHP;
            dgvLHP.DataSource = bdsLHP;
        }

        private void dgvLHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexLHP = dgvLHP.CurrentRow.Index;
            lstSV = SV.getSV(lstLHP.ElementAt(indexLHP).idLHP);
            LHP lopHocPhan = lstLHP.ElementAt(indexLHP);

            bdsSV.DataSource = lstSV;
            dgvSV.DataSource = bdsSV;

            txtDinhMucSinhVien.Text = lopHocPhan.DinhMucSinhVien;
            txtGiaoVienPhuTrach.Text = lopHocPhan.GiaoVienPhuTrach;
            txtMaLHP.Text = lopHocPhan.idLHP;
            txtSoLuongSV.Text = lopHocPhan.SoLuongSinhVien;
        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuaLHP_Click(object sender, EventArgs e)
        {
            LHP lopHocPhan = lstLHP.ElementAt(indexLHP);
            new frmSuaLHP(lopHocPhan).Show();
        }
        private void btnThemLHP_Click(object sender, EventArgs e)
        {
            string maMonHoc = lstMH.ElementAt(indexMH).idMH;
            new frmThemLHP(maMonHoc).Show();
        }

        private void btnXoaLHP_Click(object sender, EventArgs e)
        {
            //string tenLopHocPhan = lstLHP.ElementAt(indexLHP).tenLHP;
            //new frmXoaLHP().Show();

            string idLHP= lstLHP.ElementAt(indexLHP).idLHP;
            LHP.xoaLHP(idLHP);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // combobox
            this.cmbMonHoc_SelectedIndexChanged(null, null);
            // LHP
            this.dgvLHP_CellContentClick(null, null);

        }

        private void dgvLHP_CellBorderStyleChanged(object sender, EventArgs e)
        {
        }
    }
}
