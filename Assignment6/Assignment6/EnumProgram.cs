using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    public enum Gender
    {
        Male = 10,
        Female,
        Not_Specified = 25
    }

    public enum Gender2 : short
    {
        Male = short.MaxValue - 3,
        Female,
        Not_Specified
    }
    public class EnumProgram
    {
        public EnumProgram()
        {

            GetGender(10);
            GetGender(11);
            GetGender(25);
            Console.WriteLine();
            GetGender2(Gender2.Male);
            GetGender2(Gender2.Female);
            GetGender2(Gender2.Not_Specified);
        }

        public void GetGender(int value)
        {
            switch (value)
            {
                case (int)Gender.Male:
                    Console.WriteLine("Male: " + (int)Gender.Male);
                    break;
                case (int)Gender.Female:
                    Console.WriteLine("Female: " + (int)Gender.Female);
                    break;
                case (int)Gender.Not_Specified:
                    Console.WriteLine("Not_Specified: " + (int)Gender.Not_Specified);
                    break;
                default:
                    Console.WriteLine("Not in Gender enum");
                    break;
            }
        }

        public void GetGender2(Gender2 value)
        {
            switch (value)
            {
                case Gender2.Male:
                    Console.WriteLine("Male: " + (short)Gender2.Male);
                    break;
                case Gender2.Female:
                    Console.WriteLine("Female: " + (short)Gender2.Female);
                    break;
                case Gender2.Not_Specified:
                    Console.WriteLine("Not_Specified: " + (short)Gender2.Not_Specified);
                    break;
                default:
                    Console.WriteLine("Not in Gender enum");
                    break;
            }
        }
    }
}
