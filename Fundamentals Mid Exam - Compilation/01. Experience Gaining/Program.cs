using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int countOfBattle = int.Parse(Console.ReadLine());
            double earnedExperience = 0;
            double sumOfExpirience = 0;
            int countGet = 0;
            int countLess = 0;
            int battleCount = 0;
            for (int i = 0; i < countOfBattle; i++)
            {
                earnedExperience = double.Parse(Console.ReadLine());
                countGet++;
                countLess++;
                battleCount++;
                if (countGet == 3)
                {
                    countGet = 0;
                    sumOfExpirience += earnedExperience * 0.15 + earnedExperience;

                }
                else if (countLess == 5)
                {
                    countLess = 0;
                    sumOfExpirience += earnedExperience - earnedExperience * 0.10;


                }
                else
                {

                    sumOfExpirience += earnedExperience;

                }
                if (sumOfExpirience >= neededExperience)
                {
                    break;
                }

            }
            if (sumOfExpirience >= neededExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battleCount} battles.");
            }
            else
            {
                double moreEx = neededExperience - sumOfExpirience;
                Console.WriteLine($"Player was not able to collect the needed experience, {moreEx:F2} more needed.");
            }
        }
    }
}
