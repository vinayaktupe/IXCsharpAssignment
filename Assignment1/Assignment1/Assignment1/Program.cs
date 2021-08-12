using System;
using NCalculator;
using CoffeeShop;
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Shop coffeeShop = new Shop();
            bool flag = false;
            int programMenu;
            while (!flag)
            {
                Console.WriteLine("Welcome to Assignment 1 \nMenu\n1. Calculator\n2. Coffee Shop\n3. Exit");
                programMenu = int.TryParse(Console.ReadLine(), out programMenu) ? programMenu : 0;

                switch (programMenu)
                {
                    case 1:
                        calculator.Start();
                        break;
                    case 2:
                        coffeeShop.StartMachine();
                        break;
                    case 3:
                        Console.WriteLine("Thank you...!");
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
        }
    }
}
