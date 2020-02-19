using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // the judge give me 83/100 points
            var group = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            decimal price = 0;
            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = group * 8.45m;
                }
                if (dayOfWeek == "Saturday")
                {
                    price = group * 9.80m;
                }
                if (dayOfWeek == "Sunday")
                {
                    price = group * 10.46m;
                }
                if (group >= 30)
                {
                    price = price - price * 0.15m;
                }
            }
            if (typeOfGroup == "Business")
            {
                if (group >= 100)
                {
                    group = group - 10;
                }
                if (dayOfWeek == "Friday")
                {
                    price = group * 10.90m;
                }
                if (dayOfWeek == "Saturday")
                {
                    price = group * 15.60m;
                }
                if (dayOfWeek == "Sunday")
                {
                    price = group * 16;
                }

            }
            if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = group * 15;
                }
                if (dayOfWeek == "Saturday")
                {
                    price = group * 20;
                }
                if (dayOfWeek == "Sunday")
                {
                    price = group * 22.5m;
                }
                if (group >= 10 && group <= 20)
                {
                    price = price - (price * 0.05m);
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
