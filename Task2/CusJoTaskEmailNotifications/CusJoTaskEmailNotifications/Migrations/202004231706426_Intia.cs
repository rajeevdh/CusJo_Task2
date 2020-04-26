namespace CusJoTaskEmailNotifications.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmailDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToAddress = c.String(),
                        FromAdress = c.String(),
                        StatusId = c.Byte(nullable: false),
                        CommCount = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmailStatus",
                c => new
                    {
                        StatusId = c.Byte(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmailStatus");
            DropTable("dbo.EmailDatas");
        }
    }
}
