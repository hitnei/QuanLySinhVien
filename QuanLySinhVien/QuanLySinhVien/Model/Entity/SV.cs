using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Model.Entity
{
    public class SV
    {
        [Key, Column(Order = 0)]
        public string idSV { get; set; }

        public string idLHP { get; set; }
        [Key, Column(Order = 1)]
        //[ForeignKey("idLHP")]
        public string hoDem { get; set; }
        public string ten { get; set; }
        public DateTime ngaySinh { get; set; }
        public string queQuan { get; set; }
    }
}
