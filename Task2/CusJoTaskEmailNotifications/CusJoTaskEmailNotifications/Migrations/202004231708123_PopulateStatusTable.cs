namespace CusJoTaskEmailNotifications.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatusTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into EmailStatus (StatusId, Status) values (1,'Created')");
            Sql("insert into EmailStatus (StatusId, Status) values (2,'InitialSent')");
            Sql("insert into EmailStatus (StatusId, Status) values (3,'Responded')");
            Sql("insert into EmailStatus (StatusId, Status) values (4,'ResponseAcknowledged')");
        }
        
        public override void Down()
        {
        }
    }
}
