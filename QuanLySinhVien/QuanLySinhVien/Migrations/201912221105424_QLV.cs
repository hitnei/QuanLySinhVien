namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QLV : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LHPs",
                c => new
                    {
                        idLHP = c.String(nullable: false, maxLength: 128),
                        DinhMucSinhVien = c.String(nullable: false, maxLength: 128),
                        idMH = c.String(),
                        SoLuongSinhVien = c.String(),
                        GiaoVienPhuTrach = c.String(),
                        tenLHP = c.String(),
                    })
                .PrimaryKey(t => new { t.idLHP, t.DinhMucSinhVien });
            
            CreateTable(
                "dbo.MHs",
                c => new
                    {
                        idMH = c.String(nullable: false, maxLength: 128),
                        tenMH = c.String(),
                    })
                .PrimaryKey(t => t.idMH);
            
            CreateTable(
                "dbo.SVs",
                c => new
                    {
                        idSV = c.String(nullable: false, maxLength: 128),
                        hoDem = c.String(nullable: false, maxLength: 128),
                        idLHP = c.String(),
                        ten = c.String(),
                        ngaySinh = c.DateTime(nullable: false),
                        queQuan = c.String(),
                    })
                .PrimaryKey(t => new { t.idSV, t.hoDem });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SVs");
            DropTable("dbo.MHs");
            DropTable("dbo.LHPs");
        }
    }
}
