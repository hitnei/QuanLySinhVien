namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SQLV : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.LHPs");
            DropPrimaryKey("dbo.SVs");
            AlterColumn("dbo.LHPs", "DinhMucSinhVien", c => c.String());
            AlterColumn("dbo.SVs", "hoDem", c => c.String());
            AddPrimaryKey("dbo.LHPs", "idLHP");
            AddPrimaryKey("dbo.SVs", "idSV");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SVs");
            DropPrimaryKey("dbo.LHPs");
            AlterColumn("dbo.SVs", "hoDem", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.LHPs", "DinhMucSinhVien", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.SVs", new[] { "idSV", "hoDem" });
            AddPrimaryKey("dbo.LHPs", new[] { "idLHP", "DinhMucSinhVien" });
        }
    }
}
