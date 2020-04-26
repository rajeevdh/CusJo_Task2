namespace CusJoTaskEmailNotifications.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EmailJobDB : DbContext
    {
        public DbSet<EmailStatus> EmailStatuses { get; set; }
        public DbSet<EmailData> EmailsData { get; set; }
        // Your context has been configured to use a 'EmailJobDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CusJoTaskEmailNotifications.Models.EmailJobDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EmailJobDB' 
        // connection string in the application configuration file.
        public EmailJobDB()
            : base("name=EmailJobDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}