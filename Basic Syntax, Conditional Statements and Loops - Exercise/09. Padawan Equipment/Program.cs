using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            decimal priceOfLightsabers = decimal.Parse(Console.ReadLine());
            decimal priceOfRobes = decimal.Parse(Console.ReadLine());
            decimal priceOfBelts = decimal.Parse(Console.ReadLine());
            decimal beltForStudents = countOfStudents - (countOfStudents / 6);
            decimal reservSabers = countOfStudents + Math.Ceiling(countOfStudents * 0.1m);
            decimal totalSum = reservSabers * priceOfLightsabers + priceOfRobes * countOfStudents + priceOfBelts * beltForStudents;
            if (totalSum <= amountOfMoney)
            {
                decimal cost = totalSum;
                Console.WriteLine($"The money is enough - it would cost {cost:F2}lv.");
            }
            else
            {
                decimal needed = totalSum - amountOfMoney;
                Console.WriteLine($"Ivan Cho will need {needed:F2}lv more.");

            }

        }
    }
}
