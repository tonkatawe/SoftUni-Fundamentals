using System;

namespace _01._Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsMade = int.Parse(Console.ReadLine());
            double lenghtOfOneStep = double.Parse(Console.ReadLine());
            int distanceNeedToTravel = int.Parse(Console.ReadLine());
            double everyFifhtStep = lenghtOfOneStep - 0.3 * lenghtOfOneStep;
            double totalDistance = 0;
            for (int i = 1; i <= stepsMade; i++)
            {
                if (i % 5 == 0)
                {
                    totalDistance += everyFifhtStep;
                    continue;
                }
                totalDistance += lenghtOfOneStep;
            }
            double totalDistanceInPercentage = (((totalDistance / 100) * 100) / distanceNeedToTravel);
            Console.WriteLine($"You travelled {totalDistanceInPercentage:F2}% of the distance!");
        }
    }
}
