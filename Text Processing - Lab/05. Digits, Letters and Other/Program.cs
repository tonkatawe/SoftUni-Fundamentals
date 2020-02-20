using System;
using System.Text;

namespace _05._DigitsLettersOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var nums = new StringBuilder();
            var letters = new StringBuilder();
            var other = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char chartext = input[i];

                if (char.IsDigit(chartext))
                {
                    nums.Append(chartext);
                }
                else if (char.IsLetter(chartext))
                {
                    letters.Append(chartext);
                }
                else
                {
                    other.Append(chartext);
                }
            }
            Console.WriteLine($"{nums}\n{letters}\n{other}");
        }
    }
}