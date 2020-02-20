using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(" ");
            string[] arrayTwo = Console.ReadLine().Split(" ");
            string output = string.Empty;
            string test = string.Empty;

            foreach (string textTwo in arrayTwo)
            {
                foreach (string textOne in arrayOne)
                {
                    if (textOne == textTwo)
                    {
                        Console.Write(textTwo + " ");
                        break;
                    }

                }
            }

        }
    }
}
