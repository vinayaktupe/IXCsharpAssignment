using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8
{
    class Teacher
    {
        MailService m;
        public string ClassName { get; set; }
        public int ClassAttendance { get; set; }

        public Teacher()
        {
            m = new MailService();
            m.SendEmailEvent+=SendAttendanceFeedback;
        }

        public void HasGoodAttendance(List<Teacher> attendanceRecords,BoolDelegate<Teacher> hasGoodAttendace) {
            foreach (Teacher classAttndnc in attendanceRecords)
            {
                if (hasGoodAttendace(classAttndnc))
                {
                    Console.WriteLine($"{classAttndnc.ClassName} has good attendance.");
                    m.SendEmail($"{classAttndnc.ClassName} has good attendance.");
                }
                else
                {
                    Console.WriteLine($"{classAttndnc.ClassName} has bad attendance.");
                    m.SendEmail($"{classAttndnc.ClassName} has bad attendance please take action.");

                }
            }
        }

        public void SendAttendanceFeedback(string feedback)
        {
            if (feedback!=null)
            {
            Console.WriteLine($"Sending feedback: {feedback}");
            }
            else
            {
                Console.WriteLine("Sending feedback mail...");
            }
        }

    }
}
