using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string revers = string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                revers += text[i];
            }
            Console.WriteLine(revers);
        }
    }
}
