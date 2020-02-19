using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            short lostGames = short.Parse(Console.ReadLine());
            float headSetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            short counter = 0;
            float expenses = 0;
            for (short i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    expenses += headSetPrice;
                }
                if (i % 3 == 0)
                {
                    expenses += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    expenses += keyboardPrice;
                    counter++;
                }
                if (counter == 2)
                {
                    expenses += displayPrice;
                    counter = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
