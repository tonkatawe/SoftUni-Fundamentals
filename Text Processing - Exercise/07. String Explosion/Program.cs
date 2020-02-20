using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int endIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (endIndex > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);
                    endIndex--;
                    i--;
                }
                else if (input[i] == '>')
                {
                    endIndex += int.Parse(input[i + 1].ToString());
                }
            }
            Console.WriteLine(string.Join("", input));
        }
    }

}