using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            char currLetter = '0';
            for (int i = 0; i < input.Length; i++)
            {
                if (currLetter != input[i])
                {
                    result.Append(input[i]);
                }
                currLetter = input[i];
            }
            Console.WriteLine(result.ToString());
        }
    }
}
