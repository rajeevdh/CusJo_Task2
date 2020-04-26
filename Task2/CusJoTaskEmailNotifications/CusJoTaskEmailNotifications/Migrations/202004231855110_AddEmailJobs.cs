namespace CusJoTaskEmailNotifications.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailJobs : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into EmailDatas (ToAddress,FromAdress,StatusId,CommCount) values ('rajeevdh99@gmail.com','rajeevdh99@gmail.com',1,0)");
            Sql("Insert into EmailDatas (ToAddress,FromAdress,StatusId,CommCount) values ('rajeevdh99@gmail.com','rajeevdh99@gmail.com',2,0)");
            Sql("Insert into EmailDatas (ToAddress,FromAdress,StatusId,CommCount) values ('rajeevdh99@gmail.com','rajeevdh99@gmail.com',3,0)");
            Sql("Insert into EmailDatas (ToAddress,FromAdress,StatusId,CommCount) values ('rajeevdh99@gmail.com','rajeevdh99@gmail.com',1,0)");
        }
        
        public override void Down()
        {
        }
    }
}
