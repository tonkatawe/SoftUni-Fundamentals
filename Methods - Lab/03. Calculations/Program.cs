using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string commad = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            switch (commad)
            {
                case "add":
                    Add(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;
                case "multiply":
                    Multiply(a, b);
                    break;
                case "subtract":
                    Subtract(a, b);
                    break;
                default:
                    break;
            }
        }
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
