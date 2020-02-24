using System;

namespace _01._Dream_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var mitkoStartSalary = double.Parse(Console.ReadLine());
            var monthlyCosts = double.Parse(Console.ReadLine());
            var promoteSalary = double.Parse(Console.ReadLine());
            var dreamCarPrice = double.Parse(Console.ReadLine());
            var monthCountSaving = int.Parse(Console.ReadLine());
            double earnedMonths = 0;
            var costs = monthlyCosts * monthCountSaving;

            for (int i = 0; i < monthCountSaving; i++)
            {
                earnedMonths +=  mitkoStartSalary;
                mitkoStartSalary += promoteSalary;
            }
            var restSum = earnedMonths - costs;
            if (restSum >= dreamCarPrice)
            {
                Console.WriteLine("Have a nice ride!");
            }
            else
            {
                Console.WriteLine("Work harder!");
            }
        }
    }
}
