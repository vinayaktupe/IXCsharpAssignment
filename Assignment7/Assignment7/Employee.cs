using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    public delegate bool PromotionConditionDel(Employee emp);

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int YOJ { get; set; }
        public double Performance { get; set; }
        public bool HasAdditionalCertificate { get; set; }
        public static int CurrentYear = 2021;
    }

    public static class EmployeeDriver
    {
        public static List<Employee> employees;
        static EmployeeDriver()
        {
            employees = new List<Employee>();
            employees.Add(new Employee() { ID = 1, Name = "John", Salary = 24500, YOJ = 2017, Performance = 9, HasAdditionalCertificate = false });
            employees.Add(new Employee() { ID = 2, Name = "Mary", Salary = 45000, YOJ = 2019, Performance = 5, HasAdditionalCertificate = false });
            employees.Add(new Employee() { ID = 3, Name = "Sam", Salary = 20000, YOJ = 2016, Performance = 8, HasAdditionalCertificate = true });
            employees.Add(new Employee() { ID = 4, Name = "Joan", Salary = 26500, YOJ = 2011, Performance = 4, HasAdditionalCertificate = false });
            employees.Add(new Employee() { ID = 5, Name = "Santiago", Salary = 20500, YOJ = 2020, Performance = 7, HasAdditionalCertificate = true });
            employees.Add(new Employee() { ID = 6, Name = "Jason", Salary = 90000, YOJ = 2016, Performance = 6, HasAdditionalCertificate = true });
            employees.Add(new Employee() { ID = 7, Name = "Emily", Salary = 12300, YOJ = 2015, Performance = 10, HasAdditionalCertificate = false });

        }

        public static void IsPromotable(PromotionConditionDel conditionDel)
        {
            foreach (Employee employee in employees)
            {
                if (conditionDel(employee))
                {
                    Console.WriteLine($"{employee.Name} can be promoted.");
                }

            }
        }
    }

    public class EmployeeDelDriver
    {
        public EmployeeDelDriver()
        {

            Console.WriteLine("Promotion Based On:\n1]Salary greater than 25000/-\n2]More than 5 years in Company\n3]Performance greater than 5\n4]Having additional certificate");
            int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : 0;

            switch (choice)
            {
                case 1:
                    EmployeeDriver.IsPromotable(PromoteOnSalary);
                    break;
                case 2:
                    EmployeeDriver.IsPromotable(PromoteOnYOJ);
                    break;
                case 3:
                    EmployeeDriver.IsPromotable(PromoteOnPerformance);
                    break;
                case 4:
                    EmployeeDriver.IsPromotable(PromoteOnAdditionalCertificate);
                    break;
                default:
                    Console.WriteLine("Sorry! Invalid Choice..");
                    break;
            }
        }

        public bool PromoteOnSalary(Employee emp)
        {
            if (emp.Salary > 25000)
            {
                return true;
            }
            return false;
        }

        public bool PromoteOnYOJ(Employee emp)
        {
            if ((2021 - emp.YOJ) > 5)
            {
                return true;
            }
            return false;
        }

        public bool PromoteOnPerformance(Employee emp)
        {
            if (emp.Performance >= 6)
            {
                return true;
            }
            return false;
        }
        public bool PromoteOnAdditionalCertificate(Employee emp)
        {
            return emp.HasAdditionalCertificate;
        }
    }
}
