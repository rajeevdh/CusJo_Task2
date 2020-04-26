using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailNotification.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Web;

namespace EmailNotification
{
    class Essential : IDisposable
    {
        EmailDbContext _context;
        public Essential()
        {
            _context = new EmailDbContext();
        }
        public List<EmailData> RetriveEmailsToSend(int id)
        {
            List<EmailData> PendingEmails = new List<EmailData>();
            try
            {
                if (id == 2)
                    PendingEmails = _context.EmailDatas.Where(c => c.StatusId == id && c.CommCount <= 3).ToList();
                else
                    PendingEmails = _context.EmailDatas.Where(c => c.StatusId == id).ToList();
            }
            catch (Exception)
            {

            }

            return PendingEmails;
        }

        public void SendEmails(List<EmailData> EmailList, int id)
        {

            try
            {
                if (EmailList.Count > 0)
                {
                    foreach (EmailData email in EmailList)
                    {
                        string body = "";
                        string link = "";
                        MailAddress to = new MailAddress(email.ToAddress);
                        MailAddress from = new MailAddress(email.FromAdress);
                        MailMessage mail = new MailMessage(from, to);
                        link = "http://localhost:57549/API/RecordResponse/AcceptReponse/" + email.Id;
                        //link = "<a href='http://localhost:57549/" + @Url.Action("AcceptReponse", "RecordResponse", new { id = 1 }) + "'>here</a>";
                        if (id == 1)
                            body = "To Respond, please click <a href=" + link + "> here</a>";
                        else if (id == 2)
                            body = "Reminder!!->Please click <a href=" + link + "> here</a>";
                        else if (id == 3)
                            body = "Thank you for responding";

                        mail.Subject = "Notification";
                        mail.IsBodyHtml = true;
                        mail.Body = body;

                        SendEmail(mail, email.Id);


                    }

                }
            }
            catch (Exception)
            {
            }                    
        }
        public void SendEmail(MailMessage emailMessage, int id)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                smtp.Credentials = new NetworkCredential("rajeevdh99@gmail.com", "*******");
                smtp.EnableSsl = true;
                smtp.Send(emailMessage);

                EmailData updateEmail = new EmailData();
                updateEmail = _context.EmailDatas.FirstOrDefault(c => c.Id == id);

                if(updateEmail.StatusId == 1)
                {
                    updateEmail.StatusId = 2;
                    updateEmail.CommCount = 1;
                    _context.SaveChanges();
                }
                else if(updateEmail.StatusId == 2)
                {
                    updateEmail.CommCount++;
                    _context.SaveChanges();
                }
                else if(updateEmail.StatusId == 3)
                {
                    updateEmail.StatusId = 4;
                    _context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        public void Dispose()
        {

        }
    }
}
