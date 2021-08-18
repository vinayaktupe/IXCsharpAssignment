using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8
{
    public class Student
    {
        List<Student> students = new List<Student>();
        static MailService m;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
        public double MarksSub1 { get; set; }
        public double MarksSub2 { get; set; }
        public double MarksSub3 { get; set; }
        public double MarksSub4 { get; set; }

        public Student()
        {
            m = new MailService();
            m.SendEmailEvent += ShareResult;
        }

        public void IsPassed(List<Student> students, BoolDelegate<Student> getStudentResult)
        {
            foreach (Student stud in students)
            {
                if (getStudentResult(stud))
                {
                    Console.WriteLine($"{stud.Name} is Passed");
                    m.SendEmail();
                    //m.SendEmail($"Sharing result with {stud.Name}");
                }
            }
        }

        public void ShareResult(string message = null)
        {
            if (message != null)
            {
                Console.WriteLine(message);
            }
            else
            {
            Console.WriteLine($"Sharing Results with student");
            }
        }
    }
}
