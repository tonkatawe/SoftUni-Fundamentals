using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int n = 2; n <= number; n++)
            {
                string check = "true";
                for (int cepitel = 2; cepitel < n; cepitel++)
                {
                    if (n % cepitel == 0)
                    {
                        check = "false";
                        break;
                    }
                }
                Console.WriteLine($"{n} -> {check}");
            }
        }
    }
}
