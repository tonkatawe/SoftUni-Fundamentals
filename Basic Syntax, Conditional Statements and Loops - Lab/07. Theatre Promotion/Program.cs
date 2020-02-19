using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 <= age <= 18	18 < age <= 64	64 < age <= 122
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            if (dayType == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 12;
                }
                if (age > 18 && age <= 64)
                {
                    price = 18;
                }
                if (age > 64 && age <= 122)
                {
                    price = 12;
                }
            }
            if (dayType == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                }
                if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                if (age > 64 && age <= 122)
                {
                    price = 15;
                }
            }
            if (dayType == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
