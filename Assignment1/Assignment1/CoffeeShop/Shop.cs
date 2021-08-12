using System;

namespace CoffeeShop
{
    public class Shop
    {
        public void StartMachine()
        {
            bool flag = false;
            int total = 0;
            while (!flag)
            {
                Console.WriteLine("\n\nWelcome to Coffee Shop");
                Console.WriteLine("Menu:\n1]Add Small Coffee\n2]Add Medium Coffee\n3]Add Large Coffee");
                int coffeeChoice;

                coffeeChoice = int.TryParse(Console.ReadLine(), out coffeeChoice) ? coffeeChoice : 0;

                switch (coffeeChoice)
                {
                    case 1:
                        total += 1;
                        break;
                    case 2:
                        total += 2;
                        break;
                    case 3:
                        total += 3;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("Want to Add More Coffee - Yes or No?");
                string replayChoice = Console.ReadLine().ToLower();
                if (replayChoice == "no")
                {
                    if (total > 0)
                    {
                        Console.WriteLine($"You total bill is {total}");
                    }
                    Console.WriteLine($"Thank You! Visit again... :)\n\n");
                    flag = true;
                }
            }
        }
    }
}
