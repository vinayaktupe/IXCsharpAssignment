using System;

public class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee FTE = new FullTimeEmployee("John Doe", "+91-8772330182", "1", "Accounts", "ACC123", "IncubXperts", "+91-8394710374", "Karve Nagar", "IX123", "REGIX123")
        { Basic = 5000, HRA = 3000, Allowances = 1200 };
        FTE.CalculateSalary();
        FTE.Details();
        Console.WriteLine("\n\n");

        PartTimeEmployee PTE = new PartTimeEmployee("Mark Smith", "+91-9972450171", "2", "HR", "HR123", "IncubXperts", "+91-8394710374", "Karve Nagar", "IX123", "REGIX123")
        { HourlyRate = 50, WorkingHours = 12 };
        PTE.CalculateSalary();
        PTE.Details();
    }
}
