using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();
            CheckType(type, input);
        }
        static void CheckType(string type, string input)
        {
            if (type == "int")
            {
                int integer = int.Parse(input) * 2;
                Console.WriteLine(integer);
            }
            if (type == "real")
            {
                double real = double.Parse(input) * 1.5;
                Console.WriteLine($"{real:F2}");
            }
            if (type == "string")
            {
                Console.WriteLine($"${input}$");
            }
        }

    }
}
