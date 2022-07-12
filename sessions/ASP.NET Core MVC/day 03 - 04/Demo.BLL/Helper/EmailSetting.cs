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
        public static void SendEmail(Email email)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("omarredaelsayed2@gmail.com", "ULV02VQH");
            client.Send("omarredaelsayed2@gmail.com", "omarredaelsayied@gmail.com", email.Tilte, email.Body);
        }
    }
}
