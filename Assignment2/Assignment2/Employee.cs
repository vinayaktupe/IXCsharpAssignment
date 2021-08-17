using System;

//SINGLE and HIERARCHICAL INHERITANCE
public class Employee : Department
{
    public string EmployeeName { set; get; }
    public string EmployeeNumber { set; get; }
    public string EmployeeID { set; get; }

    public Employee(string EmpName, string EmpNumber, string EmpID, string DeptName, string DeptID, string OfficeName, string OfficeNumber, string OfficeAddress, string OfficeID, string OfficeRegistration)
        : base(DeptName, DeptID, OfficeName, OfficeNumber, OfficeAddress, OfficeID, OfficeRegistration)
    {
        this.EmployeeName = EmpName;
        this.EmployeeNumber = EmpNumber;
        this.EmployeeID = EmpID;
    }

    public virtual void Details()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"ID: {this.EmployeeID}");
        Console.WriteLine($"Name: {this.EmployeeName}");
        Console.WriteLine($"Number: {this.EmployeeNumber}");
    }

}
