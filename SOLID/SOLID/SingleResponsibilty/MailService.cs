using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibilty
{
    public class MailService
    {
        public void SendMail(string subject, string body)
        {
            Console.WriteLine("mail stnded.");
        }
    }
}
