using System;

//MULTIPLE INHERITANCE
public class FullTimeEmployee : Employee, ISalary
{
    public int Basic { set; get; }
    public int HRA { set; get; }
    public int Allowances { set; get; }
    public static int ProfesionalTax = 200;
    public double GrossSalary;
    public double GrossDeduction;
    public double NetSalary;

    //CONSTRUCTOR OVERLOADING
    public FullTimeEmployee(string EmpName, string EmpNumber, string EmpID, string DeptName, string DeptID, string OfficeName, string OfficeNumber, string OfficeAddress, string OfficeID, string OfficeRegistration)
        : base(EmpName, EmpNumber, EmpID, DeptName, DeptID, OfficeName, OfficeNumber, OfficeAddress, OfficeID, OfficeRegistration)
    {
    }

    public FullTimeEmployee(int Basic, int HRA, int Allowances, string EmpName, string EmpNumber, string EmpID, string DeptName, string DeptID, string OfficeName, string OfficeNumber, string OfficeAddress, string OfficeID, string OfficeRegistration)
        : base(EmpName, EmpNumber, EmpID, DeptName, DeptID, OfficeName, OfficeNumber, OfficeAddress, OfficeID, OfficeRegistration)
    {
        this.Basic = Basic;
        this.HRA = HRA;
        this.Allowances = Allowances;
        CalculateSalary();
    }

    public void CalculateSalary()
    {
        this.GrossDeduction = (this.Basic * .12) * 2;
        this.GrossSalary = this.Basic + this.HRA + this.Allowances + this.GrossDeduction;
        this.NetSalary = this.GrossSalary - this.GrossDeduction;
    }

    public void GetSalary()
    {
        Console.WriteLine($"Gross Salary Per Month: {this.GrossSalary} Rs.");
        Console.WriteLine($"Net Salary Per Month: {this.NetSalary} Rs.");

        Console.WriteLine($"Gross Yearly Salary: {this.GrossSalary * 12} Rs.");
        Console.WriteLine($"Net Yearly Salary: {this.NetSalary * 12} Rs.");
    }

    //METHOD OVERRIDING
    public override void Details()
    {
        base.Details();
        this.GetSalary();
    }
}
