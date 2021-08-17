using System;

//SUPER CLASS
public class Office
{
    public string OfficeName { get; set; }
    public string OfficeTelephone { get; set; }
    public string OfficeAddress { get; set; }
    public string OfficeID { get; set; }

    //ABSTRACTION
    private string _officeregisterationNumber;

    public Office(string OfficeName, string OfficeNumber, string OfficeAddress, string OfficeID, string OfficeRegistration)
    {
        this.OfficeName = OfficeName;
        this.OfficeTelephone = OfficeNumber;
        this.OfficeAddress = OfficeAddress;
        this.OfficeID = OfficeID;
        SetOfficeRegisterationNumber(OfficeRegistration);
    }

    public void SetOfficeRegisterationNumber(string Number)
    {
        if (Number.Length == 8)
        {
            this._officeregisterationNumber = Number;

        }
        else
        {
            Console.WriteLine("Registration Number should be 8 digit long.");
        }
    }

    public string GetOfficeRegisterationNumber()
    {
        return "XXX" + this._officeregisterationNumber.Substring(3);
    }


}
