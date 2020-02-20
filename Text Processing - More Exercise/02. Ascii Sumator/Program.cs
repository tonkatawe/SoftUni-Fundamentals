using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            string randomString = Console.ReadLine();
            int sumAscii = 0;
            for (int i = 0; i < randomString.Length; i++)
            {
                if (randomString[i] > startChar && randomString[i] < endChar)
                {
                    sumAscii += (int)randomString[i];
                }
            }
            Console.WriteLine(sumAscii);
        }
    }
}
