using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Model.Entity
{
    public class MH
    {
        [Key, Column(Order =0)]
        public string idMH { get; set; }
        public string tenMH { get; set; }
        public static List<MH> getMH()
        {
            var db = new SLSVContext();
            List<MH> lst = db.MHDbContext.Select(e => e).ToList();
            return lst;
        }

    }
}
