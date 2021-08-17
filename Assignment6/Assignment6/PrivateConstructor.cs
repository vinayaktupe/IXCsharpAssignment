using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    public class PrivateConstructor
    {
        private string _firstName;
        private string _lastName;

        public static PrivateConstructor privateConstructor = new PrivateConstructor();

        private PrivateConstructor()
        {
            _firstName = "John";
            _lastName = "Doe";
        }

        public string GetName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
