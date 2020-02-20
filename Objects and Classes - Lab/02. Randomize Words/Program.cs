using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sometext = Console.ReadLine().Split(' ');

            Random rnd = new Random();
            for (int i = 0; i < sometext.Length; i++)
            {
                int randomNum = rnd.Next(i, sometext.Length);
                string randomEl = sometext[randomNum];
                string el = sometext[i];
                sometext[randomNum] = el;
                sometext[i] = randomEl;
            }
            Console.WriteLine(string.Join(Environment.NewLine, sometext));

        }
    }
}
