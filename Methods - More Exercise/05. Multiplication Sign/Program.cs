using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            NegativeOrPostivie(num, num1, num2);
        }
        static void NegativeOrPostivie(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("negative");
            }
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("positive");
            }
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
            }
        }
    }
}
