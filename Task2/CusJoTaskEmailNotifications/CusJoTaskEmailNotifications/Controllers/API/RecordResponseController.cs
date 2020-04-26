using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CusJoTaskEmailNotifications.Models;

namespace CusJoTaskEmailNotifications.Controllers.API
{
    [AllowAnonymous]
    public class RecordResponseController : ApiController
    {
        EmailJobDB _context;

        public RecordResponseController()
        {
            _context = new EmailJobDB();
        }

        [HttpPut]
        public IHttpActionResult AcceptReponse(int id)
        {
            try
            {
                EmailData UpdateStatus = new EmailData();
                UpdateStatus = _context.EmailsData.FirstOrDefault(c => c.Id == id);

                if (UpdateStatus != null)
                {
                    if (UpdateStatus.StatusId == 2)
                    {
                        UpdateStatus.StatusId = 3;
                        _context.SaveChanges();
                        return Ok("Response Recored");
                    }
                    else if (UpdateStatus.StatusId == 3)
                    {
                        return Ok("Response Recored");
                    }
                    else if (UpdateStatus.StatusId == 3)
                    {
                        return Ok("Your respnse has already acknowledged");
                    }
                }

                return BadRequest("Response Not Recored");
            }
            catch (Exception)
            {
                return BadRequest("Response Not Recored");
            }
        }
    }
}
