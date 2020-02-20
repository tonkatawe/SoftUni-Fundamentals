using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            sbyte left = 0;
            sbyte right = 0;
            char code;
            string statment = string.Empty;
            string symbol = string.Empty;

            for (int i = 1; i <= numberOfStrings; i++)
            {
                symbol = Console.ReadLine();
                statment += symbol;
            }
            if (statment.Length <= 100 && statment.Length >= 1)
            {
                for (int i = 0; i <= statment.Length - 1; i++)
                {
                    code = statment[i];

                    if (code == '(')
                    {
                        left++;
                    }
                    if (code == ')')
                    {
                        right++;
                    }
                }

            }
            if (left == right && left > 0 && right > 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
