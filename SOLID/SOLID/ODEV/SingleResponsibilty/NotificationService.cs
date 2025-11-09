using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ODEV.SingleResponsibilty
{
    public class NotificationService
    {
        public void SendNotification (string message)
        {
            Console.WriteLine($"Bildirim gönderildi: {message}");
        }
    }
}
