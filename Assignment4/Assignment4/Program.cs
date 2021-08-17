using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABSTRACT METHOD
            AbstractMethodDemo abstractMethodDemo = new AbstractDriver();
            abstractMethodDemo.Print();

            //EXTENSION METHOD
            Console.WriteLine("Extension Method Result");
            Console.WriteLine(10.Add());
            Console.WriteLine(10.Add(20, 30));
            Console.WriteLine(10.Multiply());
            Console.WriteLine(10.Multiply(2, 3));

            //INSTANCE METHOD
            Console.WriteLine("Instance Method Result");
            InstanceMethodDemo instanceMethodDemo = new InstanceMethodDemo();
            Console.WriteLine(instanceMethodDemo.Add(10));
            Console.WriteLine(instanceMethodDemo.Add(20, 30));
            Console.WriteLine(instanceMethodDemo.Multiply(10));
            Console.WriteLine(instanceMethodDemo.Multiply(2, 3));

            //PARTIAL METHOD
            PartialMethodDemo partialMethodDemo = new PartialMethodDemo();
            partialMethodDemo.Print();

            //STATIC METHOD
            StaticMethodDemo.Area(5.4f);

            //VIRTUAL METHOD
            VirtualMethodDemo virtualMethodDemo = new Child();
            virtualMethodDemo.Print();


            //DIFFERENCE BETWEEN VAR AND DYNAMIC
            new VarAndDynamic();
        }
    }
}
