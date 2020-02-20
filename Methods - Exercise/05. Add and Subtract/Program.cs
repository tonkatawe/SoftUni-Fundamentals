using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = Sum(a, b);
            Console.WriteLine(Subtract(result, c));
        }
        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }

}
