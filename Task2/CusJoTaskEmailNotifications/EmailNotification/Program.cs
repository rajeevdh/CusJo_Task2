using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailNotification.Model;
using EmailNotification.DataModel;

namespace EmailNotification
{
    class Program
    {

        static void Main(string[] args)
        {
            using (Essential Essentials = new Essential()) {
                try
                {
                    List<EmailData> EmailsToSendCreated = new List<EmailData>();
                    List<EmailData> EmailsToSendInitial = new List<EmailData>();
                    List<EmailData> EmailsToSendResponded = new List<EmailData>();

                    EmailsToSendCreated = Essentials.RetriveEmailsToSend(1);
                    EmailsToSendInitial = Essentials.RetriveEmailsToSend(2);
                    EmailsToSendResponded = Essentials.RetriveEmailsToSend(3);
                    
                    if(EmailsToSendCreated !=null)
                    Essentials.SendEmails(EmailsToSendCreated,1);
                    if(EmailsToSendInitial !=null)
                    Essentials.SendEmails(EmailsToSendInitial,2);
                    if(EmailsToSendResponded != null)
                    Essentials.SendEmails(EmailsToSendResponded,3);

                }
                catch (Exception)
                {

                }
            }
        }            
    }
}
