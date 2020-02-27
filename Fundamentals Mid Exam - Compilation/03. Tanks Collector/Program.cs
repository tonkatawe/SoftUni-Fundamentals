using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> alreadyOwnedTanks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());
            string typeOfThank = string.Empty;
            int thankIndexInList = 0;
            List<string> tokens = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (tokens[0] == "Add")
                {
                    typeOfThank = tokens[1];
                    AddThank(alreadyOwnedTanks, typeOfThank);
                }
                if (tokens[0] == "Remove")
                {
                    typeOfThank = tokens[1];
                    RemoveThank(alreadyOwnedTanks, typeOfThank);
                }
                if (tokens[0] == "Remove At")
                {
                    thankIndexInList = int.Parse(tokens[1]);
                    RemoveIndex(alreadyOwnedTanks, thankIndexInList);
                }
                if (tokens[0] == "Insert")
                {
                    thankIndexInList = int.Parse(tokens[1]);
                    typeOfThank = tokens[2];
                    if (thankIndexInList > alreadyOwnedTanks.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        InsertThanks(alreadyOwnedTanks, thankIndexInList, typeOfThank);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", alreadyOwnedTanks));

        }
        static void InsertThanks(List<string> thanks, int thankIndex, string typeOfTanks)
        {
            bool isThanksAlreadyInList = thanks.Contains(typeOfTanks);
            if (isThanksAlreadyInList)
            {
                Console.WriteLine("Tank is already bought");
            }
            if (thankIndex >= thanks.Count && thankIndex >= 0)
            {
                Console.WriteLine("Index out of range");
            }
            else
            {
                Console.WriteLine("Tank successfully bought");
                thanks.Insert(thankIndex, typeOfTanks);
            }
        }
        static void AddThank(List<string> thanks, string typeOfTanks)
        {
            bool isThanksAlreadyInList = thanks.Contains(typeOfTanks);
            if (isThanksAlreadyInList)
            {
                Console.WriteLine("Tank is already bought");
            }
            else
            {
                thanks.Add(typeOfTanks);
                Console.WriteLine("Tank successfully bought");
            }

        }
        static void RemoveThank(List<string> thanks, string typeOfTanks)
        {
            bool isThanksAlreadyInList = thanks.Contains(typeOfTanks);
            if (isThanksAlreadyInList)
            {
                Console.WriteLine("Tank successfully sold");
                thanks.Remove(typeOfTanks);
            }
            else
            {
                Console.WriteLine("Tank not found");
            }

        }
        static void RemoveIndex(List<string> thanks, int indexOfThank)
        {

            if (indexOfThank <= thanks.Count && indexOfThank >= 0)
            {
                Console.WriteLine("Tank successfully sold");
                thanks.RemoveAt(indexOfThank);
            }
            else
            {
                Console.WriteLine("Index out of range");
            }

        }

    }
}
