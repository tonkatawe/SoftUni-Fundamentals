using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(MiddleCharacters(text));
        }
        static string MiddleCharacters(string text)
        {
            string middle = string.Empty;
            int n = text.Length;
            if (n % 2 == 0)
            {
                char first = text[(text.Length / 2) - 1];
                char second = text[text.Length / 2];
                middle = first.ToString() + second.ToString();
            }
            else
            {
                middle = text.Substring(text.Length / 2, 1);
            }
            return middle;
        }
    }
}
