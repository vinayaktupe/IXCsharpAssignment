using System;

namespace AbstractClassDemo
{
    public abstract class Animal
    {
        public abstract void Voice();
    }

    public class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    public class Cat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Cat Meows");
        }
    }
}
