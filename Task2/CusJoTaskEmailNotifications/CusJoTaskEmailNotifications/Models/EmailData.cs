using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CusJoTaskEmailNotifications.Models
{
    public class EmailData
    {
        [Key]
        public int Id { get; set; }
        public string ToAddress { get; set; }
        public string FromAdress { get; set; }
        public byte StatusId { get; set; }
        public byte CommCount { get;  set; }
    }
}