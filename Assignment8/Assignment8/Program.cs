using System;
using System.Collections.Generic;

namespace Assignment8
{
    public delegate bool BoolDelegate<T>(T item);

    class Program
    {
        static void Main(string[] args)
        {

            //STUDENT
            List<Student> students = new List<Student>();
            students.Add(new Student() { ID = 1, Name = "Ravi", Standard = "12", MarksSub1 = 40, MarksSub2 = 50, MarksSub3 = 55, MarksSub4 = 42 });
            students.Add(new Student() { ID = 1, Name = "Vinayak", Standard = "12", MarksSub1 = 20, MarksSub2 = 40, MarksSub3 = 55, MarksSub4 = 40 });
            students.Add(new Student() { ID = 1, Name = "Atharva", Standard = "12", MarksSub1 = 45, MarksSub2 = 10, MarksSub3 = 85, MarksSub4 = 42 });
            students.Add(new Student() { ID = 1, Name = "Veena", Standard = "12", MarksSub1 = 48, MarksSub2 = 65, MarksSub3 = 59, MarksSub4 = 48 });
            students.Add(new Student() { ID = 1, Name = "Tanmay", Standard = "12", MarksSub1 = 25, MarksSub2 = 55, MarksSub3 = 52, MarksSub4 = 45 });
            students.Add(new Student() { ID = 1, Name = "Prajakta", Standard = "12", MarksSub1 = 49, MarksSub2 = 60, MarksSub3 = 75, MarksSub4 = 41 });

            //new Student().IsPassed(students, (Student student) => student.MarksSub1 >= 40 && student.MarksSub2 >= 40 && student.MarksSub3 >= 40);

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher() { ClassName = "First Year", ClassAttendance = 87 });
            teachers.Add(new Teacher() { ClassName = "Second Year", ClassAttendance = 45 });
            teachers.Add(new Teacher() { ClassName = "Third Year", ClassAttendance = 63 });
            teachers.Add(new Teacher() { ClassName = "Final Year", ClassAttendance = 76 });

            new Teacher().HasGoodAttendance(teachers, (Teacher teacher) => teacher.ClassAttendance > 75);
            List<Fees> fees = new List<Fees>();
            fees.Add(new Fees() { Year = 1, PersonName = "John", fee = 24500 });
            fees.Add(new Fees() { Year = 2, PersonName = "Mary", fee = 34000 });
            fees.Add(new Fees() { Year = 3, PersonName = "May", fee = 24000 });
            fees.Add(new Fees() { Year = 3, PersonName = "Smith", fee = 10000 });
            fees.Add(new Fees() { Year = 2, PersonName = "Joan", fee = 20000 });
            fees.Add(new Fees() { Year = 1, PersonName = "Sam", fee = 15000 });
            //new Fees().HasPaidCompleteFees(fees, (Fees fee) => fee.Year == 1 && fee.fee < 25000);

        }
    }
}
