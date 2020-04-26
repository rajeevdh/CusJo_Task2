namespace SendEmails
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmailDB : DbContext
    {
        public EmailDB()
            : base("name=EmailDB")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<EmailData> EmailDatas { get; set; }
        public virtual DbSet<EmailStatu> EmailStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
