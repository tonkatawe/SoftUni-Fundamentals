using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double amountPlunder = 0;
            if (days > 0 && dailyPlunder > 0 && expectedPlunder > 0)
            {
                for (int i = 1; i <= days; i++)
                {
                    amountPlunder += dailyPlunder;
                    if (i % 3 == 0)
                    {
                        amountPlunder += dailyPlunder * 0.5;
                    }
                    if (i % 5 == 0)
                    {
                        amountPlunder = amountPlunder - amountPlunder * 0.3;
                    }

                }
            }
            if (amountPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {amountPlunder:F2} plunder gained.");
            }
            else if (amountPlunder < expectedPlunder)
            {
                var percentToReach = amountPlunder * 100 / expectedPlunder;
                Console.WriteLine($"Collected only {percentToReach:F2}% of the plunder.");
            }
        }
    }
}
