using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    public class BoxAndUnBox
    {
        public BoxAndUnBox()
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            int[] arr2 = arr;

            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2[1]);
            Console.WriteLine(arr2[2]);


            //BOXING
            int i = 123;
            object obj = i;

            //UNBOXING
            int j = (int)obj;

            Console.WriteLine($"obj: " + obj);
            Console.WriteLine("j: " + j);

            //BOXING
            obj = 3.14f;
            //UNBOXING
            float ft = (float)obj;
            Console.WriteLine($"obj: " + obj);
            Console.WriteLine("ft: " + ft);

            object demoObj = new Demo();

            
            

        }

        class Demo
        {
            public int FN { get; set; }
            public int SN { get; set; }

            public Demo()
            {
                FN = 0;
                SN = 0;
            }
        }
    }
}
