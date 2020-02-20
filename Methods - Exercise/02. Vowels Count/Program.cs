using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCount(input));

        }
        static int VowelsCount(string text)
        {
            int counter = 0;
            for (int i = 0; i <= text.Length - 1; i++)
            {
                char letter = text[i];

                if (letter == 'a' || letter == 'e' || letter == 'o' || letter == 'i' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'O' || letter == 'I' || letter == 'U')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
