using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8
{
    class MailService
    {
        public delegate void SendEmailDelegate(string message = null);
        public event SendEmailDelegate SendEmailEvent;

        public void SendEmail(string message = null)
        {
            if (SendEmailEvent != null)
            {
                SendEmailEvent(message);
                Console.WriteLine("Email sent.");
            }
        }
    }
}
