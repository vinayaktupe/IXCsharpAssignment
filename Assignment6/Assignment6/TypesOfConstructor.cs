using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    public class TypesOfConstructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public TypesOfConstructor()
        {
            FirstName = LastName = string.Empty;
        }

        public TypesOfConstructor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public TypesOfConstructor(TypesOfConstructor Obj)
        {
            FirstName = Obj.FirstName;
            LastName = Obj.LastName;
        }
    }
}
