using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int mainDigit = 0;
            int countDigits = 0;
            int counter = 0;
            int letterIndex = 0;
            string text = string.Empty;
            for (int i = 0; i < rows; i++)
            {
                string letters = Console.ReadLine();
                string figurs = string.Empty;
                counter = 0;
                for (int k = 0; k <= letters.Length - 1; k++)
                {
                    counter++;
                    figurs += letters[k];
                }
                countDigits = int.Parse(figurs);
                mainDigit = countDigits % 10;
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }
                letterIndex = 97 + offset + counter - 1;
                if (countDigits == 0)
                {
                    letterIndex = 32;
                }
                text += (char)(letterIndex);
            }
            Console.WriteLine(text);

        }
    }
}
