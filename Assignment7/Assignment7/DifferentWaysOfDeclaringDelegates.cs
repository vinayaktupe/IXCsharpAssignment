using System;

namespace Assignment7
{
    class DifferentWaysOfDeclaringDelegates
    {
        public delegate void LamdaDel(string str);
        public DifferentWaysOfDeclaringDelegates()
        {
            LamdaDel palindromelamdaDel = (string str) =>
            {
                int i = 0;
                int j = str.Length - 1;
                bool flag = false;
                while (i != j)
                {
                    if (str[i] != str[j])
                    {
                        flag = true;
                        break;
                    }
                    i++;
                    j--;
                }
                if (flag)
                {
                    Console.WriteLine($"{str} is not palindrome");
                }
                else
                {
                    Console.WriteLine($"{str} is palindrome");
                }
            };

            palindromelamdaDel("madam");
            palindromelamdaDel("sir");
        }
    }
}
