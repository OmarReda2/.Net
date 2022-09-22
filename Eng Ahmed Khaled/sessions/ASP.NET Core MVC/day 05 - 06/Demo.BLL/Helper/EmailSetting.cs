using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Helper
{
    public class EmailSetting
    {
        public static void SendEmail(Email email, string userEmail)
        {
            var client = new SmtpClient("smtp.ethereal.email", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("winston.okuneva59@ethereal.email", "jHX7hscHNewaXjKRGS");
            client.Send("winston.okuneva59@ethereal.email", userEmail, email.Tilte, email.Body);
        }
    }
}
