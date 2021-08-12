using System;

namespace NCalculator
{
    public class Calculator
    {
        int Add(params int[] Elements)
        {
            int result = 0;
            foreach (int element in Elements)
            {
                result += element;
            }
            return result;
        }

        float Add(params float[] Elements)
        {
            float result = 0;
            foreach (float element in Elements)
            {
                result += element;
            }
            return result;
        }

        int Substract(params int[] Elements)
        {
            if (Elements.Length >= 2)
            {
                int result = Elements[0];
                for (int i = 1; i < Elements.Length; i++)
                {
                    result -= Elements[i];
                }
                return result;
            }
            else if (Elements.Length>0 && Elements.Length <= 1)
            {
                return Elements[0];
            }
            else
            {
                return 0;
            }
        }

        float Substract(params float[] Elements)
        {
            float result = 0;
            foreach (float element in Elements)
            {
                result -= element;
            }
            return result;
        }

        int Multiply(params int[] Elements)
        {
            int result = 1;
            foreach (int element in Elements)
            {
                result *= element;
            }
            return result;
        }

        float Multiply(params float[] Elements)
        {
            float result = 0;
            foreach (float element in Elements)
            {
                result *= element;
            }
            return result;
        }


        float Divide(int numerator, int denominator)
        {
            if (denominator <= 0)
            {
                throw new Exception("Cannot divide by zero");
            }
            return numerator / denominator;
        }

        float Divide(float numerator, float denominator)
        {
            if (denominator <= 0)
            {
                throw new Exception("Cannot divide by zero");
            }
            return numerator / denominator;
        }

        int[] IntegerStringToArray(string input)
        {
            string[] stringArray = input.Split(",");
            int[] integerArray = new int[stringArray.Length];
            int i = 0;
            foreach (string item in stringArray)
            {
                if (int.TryParse(item, out integerArray[i]))
                {
                    integerArray[i] = int.Parse(item);
                    i++;
                }
            }

            return integerArray;
        }

        float[] FloatStringToArray(string input)
        {
            string[] stringArray = input.Split(",");
            float[] floatArray = new float[stringArray.Length];
            int i = 0;
            foreach (string item in stringArray)
            {
                if (float.TryParse(item, out floatArray[i]))
                {
                    floatArray[i] = int.Parse(item);
                    i++;
                }
            }

            return floatArray;
        }

        public void Start()
        {

            var numerator = 1;
            var denominator = 1;

            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("\n\nWelcome to Calculator\n1. Add\n2. Substract\n3. Multiply\n4. Divide");
                int menuChoice;
                string input = "";
                int[] arr;
                menuChoice = int.TryParse(Console.ReadLine(), out menuChoice) ? menuChoice : 0;
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter your values to add seperated by commas \",\"");
                        input = Console.ReadLine();
                        arr = IntegerStringToArray(input);
                        Console.WriteLine($"Addition: {Add(arr)}");
                        break;

                    case 2:
                        Console.WriteLine("Enter your values to substract seperated by commas \",\"");
                        input = Console.ReadLine();
                        arr = IntegerStringToArray(input);
                        Console.WriteLine($"Substraction: {Substract(arr)}");
                        break;

                    case 3:
                        Console.WriteLine("Enter your values to Multiply seperated by commas \",\"");
                        input = Console.ReadLine();
                        arr = IntegerStringToArray(input);
                        Console.WriteLine($"Multiplication: {Multiply(arr)}");
                        break;

                    case 4:

                        Console.WriteLine("Enter Value of Numerator: ");
                        string strNumerator = Console.ReadLine();
                        Console.WriteLine("Enter Value of Denominator: ");
                        string strDenominator = Console.ReadLine();
                        if (int.TryParse(strNumerator, out numerator) && int.TryParse(strDenominator, out denominator))
                        {
                            numerator = int.Parse(strNumerator);
                            denominator = int.Parse(strDenominator);
                            Console.WriteLine($"Division: {Divide(numerator, denominator)}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("Do you want to exit - Yes or No?");
                string exitChoice = Console.ReadLine().ToLower();
                if (exitChoice == "yes")
                {
                    flag = true;
                }

            }

        }
    }
}
