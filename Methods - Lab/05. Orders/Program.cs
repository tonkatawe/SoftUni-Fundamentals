using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDrink = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            Orders(typeOfDrink, quantity);
        }
        static void Orders(string text, double quantity)
        {
            switch (text)
            {
                case "water":
                    Console.WriteLine($"{quantity * 1.0:F2}");
                    break;
                case "coffee":
                    Console.WriteLine($"{quantity * 1.5:F2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity * 1.4:F2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quantity * 2:F2}");
                    break;
                default:
                    break;
            }
        }
    }
}
