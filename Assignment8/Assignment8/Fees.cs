using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8
{
    public enum Severity
    {
        high,
        medium,
        low
    }
    class Fees
    {
        public double fee { get; set; }
        public string PersonName { get; set; }
        public int Year { get; set; }
        MailService m;
        public Fees()
        {
            m = new MailService();
            m.SendEmailEvent += SendFeeAck;

        }

        public void HasPaidCompleteFees(List<Fees> fees, BoolDelegate<Fees> boolDelegate)
        {
            foreach (Fees fee in fees)
            {
                if (boolDelegate(fee))
                {
                    Console.WriteLine($"{fee.PersonName} has not paid full fees.");
                    m.SendEmail($"Hi! {fee.PersonName} please pay the full fees");
                }
            }
        }

        public void SendFeeAck(string msg = null)
        {
            if (msg != null)
            {
                Console.WriteLine($"Sending acknowlegment: {msg}");

            }
            else
            {
                Console.WriteLine("Sending acknowlegment...");
            }
        }

    }
}
