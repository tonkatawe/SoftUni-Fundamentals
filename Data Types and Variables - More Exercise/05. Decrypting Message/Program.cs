using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte key = sbyte.Parse(Console.ReadLine());
            sbyte countOfLetters = sbyte.Parse(Console.ReadLine());
            string decrypted = string.Empty;
            for (int i = 0; i < countOfLetters; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                decrypted += (char)(letter + key);
            }
            Console.WriteLine(decrypted);
        }
    }
}
