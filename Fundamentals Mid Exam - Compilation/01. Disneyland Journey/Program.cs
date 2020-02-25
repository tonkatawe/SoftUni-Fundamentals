using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double costForJourney = double.Parse(Console.ReadLine());
            int monthForSave = int.Parse(Console.ReadLine());
            double collectedMoney = 0;
            int fourMonthsCheker = 1;
            if (costForJourney > 0 && monthForSave >= 1)
            {
                for (int i = 1; i <= monthForSave; i++)
                {
                    if (i % 2 != 0 && i >= 3)
                    {
                        collectedMoney -= collectedMoney * 0.16;
                    }
                    else if (fourMonthsCheker == 4)
                    {
                        collectedMoney += collectedMoney * 0.25;
                        fourMonthsCheker = 0;
                    }
                    fourMonthsCheker++;
                    collectedMoney += 0.25 * costForJourney;
                }
            }
            if (collectedMoney >= costForJourney)
            {
                var restForSouvenirs = collectedMoney - costForJourney;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {restForSouvenirs:F2}lv. for souvenirs.");
            }
            else
            {
                var neededMoney = costForJourney - collectedMoney;
                Console.WriteLine($"Sorry. You need {neededMoney:F2}lv. more.");
            }
        }
    }
}
