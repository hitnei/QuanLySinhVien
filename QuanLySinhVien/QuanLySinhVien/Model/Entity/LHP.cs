using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.Model.Entity
{
    public class LHP
    {
        [Key, Column(Order = 0)]
        public string idLHP { get; set; }

        //[Key, Column(Order = 1)]
        //[ForeignKey("idMH")]
        public string idMH { get; set; }
        public string DinhMucSinhVien { get; set; }
        public string SoLuongSinhVien { get; set; }
        public string GiaoVienPhuTrach { get; set; }
        public string tenLHP { get; set; }

        public static List<LHP> getLHP(string maMH)
        {
            var db = new SLSVContext();
            List<LHP> lst = db.LHPDbContext.Where(e => e.idMH.Equals(maMH)).ToList();
            return lst;
        }
        public static void themLHP(LHP lopHocPhan)
        {
            if 
                (
                    lopHocPhan.idLHP == "" ||
                    lopHocPhan.tenLHP == "" ||
                    lopHocPhan.DinhMucSinhVien == "" ||
                    lopHocPhan.SoLuongSinhVien == "" ||
                    lopHocPhan.GiaoVienPhuTrach == ""
                )
            {
                MessageBox.Show("Các trường không được để trống!");
            }
            else
            {
                var db = new SLSVContext();
                db.LHPDbContext.Add(lopHocPhan);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
            }
        }
        public static void suaLHP(LHP lopHocPhan)
        {
            if
                (
                    lopHocPhan.tenLHP == "" ||
                    lopHocPhan.DinhMucSinhVien == "" ||
                    lopHocPhan.SoLuongSinhVien == "" ||
                    lopHocPhan.GiaoVienPhuTrach == ""
                )
            {
                MessageBox.Show("Các trường không được để trống!");
            }
            else
            {
                var db = new SLSVContext();
                LHP temp = db.LHPDbContext.Where(e => e.idLHP.Equals(lopHocPhan.idLHP)).FirstOrDefault();
                temp.tenLHP = lopHocPhan.tenLHP;
                temp.DinhMucSinhVien = lopHocPhan.DinhMucSinhVien;
                temp.GiaoVienPhuTrach = lopHocPhan.GiaoVienPhuTrach;
                temp.SoLuongSinhVien = lopHocPhan.SoLuongSinhVien;

                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
            }

        }
        public static void xoaLHP(string maLHP)
        {
            var db = new SLSVContext();
            LHP lopHocPhan = db.LHPDbContext.Where(e => e.idLHP.Equals(maLHP)).FirstOrDefault();
            db.LHPDbContext.Remove(lopHocPhan);
            db.SaveChanges();
            MessageBox.Show("Đã xóa lớp học phần " + maLHP);
        }
    }
}
