using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            a = FactorialFirst(a);
            b = FactorialFirst(b);
            double devide = a / b;
            Console.WriteLine($"{devide:F2}");
        }
        static double FactorialFirst(double a)
        {
            double currentA = 1;
            for (double i = a; i >= 1; i--)
            {
                currentA *= i;
            }
            return currentA;
        }
        static double FactorialSecond(double b)
        {
            double currentB = 1;
            for (double i = b; i >= 1; i--)
            {
                currentB *= i;
            }
            double result = currentB;
            return result;
        }
    }
}

