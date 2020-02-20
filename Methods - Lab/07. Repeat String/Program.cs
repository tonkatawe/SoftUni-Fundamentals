using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = Console.ReadLine();
            int countRepeat = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(repeat, countRepeat));
        }
        static string RepeatString(string text, int n)
        {
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result += text;

            }
            return result;
        }
    }

}
