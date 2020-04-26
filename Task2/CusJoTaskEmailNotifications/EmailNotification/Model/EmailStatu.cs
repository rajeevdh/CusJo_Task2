namespace EmailNotification.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmailStatu
    {
        [Key]
        public byte StatusId { get; set; }

        public string Status { get; set; }
    }
}
