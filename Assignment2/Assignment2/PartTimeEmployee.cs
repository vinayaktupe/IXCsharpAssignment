using System;

//MULTIPLE INHERITANCE
public class PartTimeEmployee : Employee, ISalary
{
    public int WorkingHours { set; get; }
    public double HourlyRate { set; get; }
    public double Salary;

    //CONSTRUCTOR OVERLOADING
    public PartTimeEmployee(string EmpName, string EmpNumber, string EmpID, string DeptName, string DeptID, string OfficeName, string OfficeNumber, string OfficeAddress, string OfficeID, string OfficeRegistration)
        : base(EmpName, EmpNumber, EmpID, DeptName, DeptID, OfficeName, OfficeNumber, OfficeAddress, OfficeID, OfficeRegistration)
    {
    }

    public PartTimeEmployee(int WorkingHours, double HourlyRate, string EmpName, string EmpNumber, string EmpID, string DeptName, string DeptID, string OfficeName, string OfficeNumber, string OfficeAddress, string OfficeID, string OfficeRegistration)
        : base(EmpName, EmpNumber, EmpID, DeptName, DeptID, OfficeName, OfficeNumber, OfficeAddress, OfficeID, OfficeRegistration)
    {
        this.WorkingHours = WorkingHours;
        this.HourlyRate = HourlyRate;
        CalculateSalary();
    }

    public void CalculateSalary()
    {
        this.Salary = this.HourlyRate * this.WorkingHours;
    }

    public void GetSalary()
    {
        Console.WriteLine($"Your Hourly Salary: {this.Salary} Rs.");
    }

    //METHOD OVERRIDING
    public override void Details()
    {
        base.Details();
        this.GetSalary();
    }
}
