using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = n;
            int num = 0;
            int sum = 0;
            int counter = 0;
            while (number != 0)
            {
                counter++;
                num = counter % 10;
                sum = counter / 10;
                if (num + sum == 5 || num + sum == 7 || num + sum == 11)
                {
                    Console.WriteLine($"{counter} -> True");

                }
                else
                {
                    Console.WriteLine($"{counter} -> False");
                }
                number--;
            }




        }
    }
}
