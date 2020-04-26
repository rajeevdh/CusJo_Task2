namespace EmailNotification.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmailData
    {
        public int Id { get; set; }

        public string ToAddress { get; set; }

        public string FromAdress { get; set; }

        public byte StatusId { get; set; }

        public byte CommCount { get; set; }
    }
}
