using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            string textDecrease = string.Empty;
            int counter = 0;
            string treasureType = string.Empty;
            string coordinations = string.Empty;
            while (text != "find")
            {
                while (counter != text.Length)
                {
                    for (int i = 0; i < key.Length; i++)
                    {
                        int currentNumberFromKey = key[i];
                        char currentChar = text[counter];
                        textDecrease += (char)(currentChar - currentNumberFromKey);
                        counter++;
                        if (counter == text.Length)
                        {
                            break;
                        }
                    }

                }

                int currentInd = textDecrease.IndexOf('&') + 1;
                for (int i = currentInd; i < textDecrease.Length; i++)
                {
                    if (textDecrease[i] == '&')
                    {
                        break;
                    }
                    treasureType += textDecrease[i];
                }
                currentInd = textDecrease.IndexOf('<') + 1;
                for (int i = currentInd; i < textDecrease.Length; i++)
                {
                    if (textDecrease[i] == '>')
                    {
                        break;
                    }
                    coordinations += textDecrease[i];
                }
                Console.WriteLine($"Found {treasureType} at {coordinations}");
                treasureType = string.Empty;
                coordinations = string.Empty;
                textDecrease = string.Empty;
                counter = 0;
                text = Console.ReadLine();
            }

        }
    }
}
