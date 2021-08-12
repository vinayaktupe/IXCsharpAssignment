using System;

namespace ExtensionMethodDemo
{
    public static class ExtensionMethodDemoClass
    {
        public static int Sum(this int a, int b)
        {
            return a + b;
        }
    }
}
