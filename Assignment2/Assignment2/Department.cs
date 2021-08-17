
//SINGLE and HIERARCHICAL INHERITANCE

public class Department : Office
{
    public string DepartmentName { set; get; }
    public string DepartmentID { set; get; }

    public Department(string DeptName, string DeptID, string OfficeName, string OfficeNumber, string OfficeAddress, string OfficeID, string OfficeRegistration)
        : base(OfficeName, OfficeNumber, OfficeAddress, OfficeID, OfficeRegistration)
    {
        this.DepartmentName = DeptName;
        this.DepartmentID = DeptID;
    }
}
