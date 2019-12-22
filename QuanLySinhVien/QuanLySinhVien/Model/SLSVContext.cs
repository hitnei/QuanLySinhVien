using QuanLySinhVien.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Model
{
    public class SLSVContext : DbContext
    {
        public SLSVContext() : base("Data Source=.;Initial Catalog=dotNetQLSV;Persist Security Info=True;User ID=sa;Password=123")
        {

        }
        public DbSet<LHP> LHPDbContext { get; set; }
        public DbSet<MH> MHDbContext { get; set; }
        public DbSet<SV> SVDbContext { get; set; }
    }
}
