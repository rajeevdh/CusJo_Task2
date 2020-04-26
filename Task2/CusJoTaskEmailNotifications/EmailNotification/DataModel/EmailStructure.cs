using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotification.DataModel
{
    class EmailStructure
    {
        public int Id { get; set; }

        public string ToAddress { get; set; }

        public string FromAdress { get; set; }

        public byte StatusId { get; set; }

        public byte CommCount { get; set; }
    }
}
