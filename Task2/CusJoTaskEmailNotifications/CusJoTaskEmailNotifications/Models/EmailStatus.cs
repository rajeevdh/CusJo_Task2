using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CusJoTaskEmailNotifications.Models
{
    public class EmailStatus
    {
        [Key]
        public byte StatusId { get; set; }
        public string Status { get; set; }
    }
}