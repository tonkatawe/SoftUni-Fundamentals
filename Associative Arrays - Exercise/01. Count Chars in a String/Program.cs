using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {

            string someText = Console.ReadLine();
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < someText.Length; i++)
            {
                char letter = someText[i];
                if (letter == ' ')
                {
                    continue;
                }
                if (!count.ContainsKey(letter))
                {
                    count[letter] = 1;
                }
                else
                {

                    count[letter] += 1;
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
