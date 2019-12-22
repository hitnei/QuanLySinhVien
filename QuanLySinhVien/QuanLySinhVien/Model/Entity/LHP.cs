using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Model.Entity
{
    public class LHP
    {
        [Key, Column(Order = 0)]
        public string idLHP { get; set; }

        public string idMH { get; set; }
        [Key, Column(Order = 1)]
        //[ForeignKey("idMH")]
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
    }
}
