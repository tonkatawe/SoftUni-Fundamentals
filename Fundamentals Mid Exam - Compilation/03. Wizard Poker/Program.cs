using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deckOfCards = Console.ReadLine().Split(':').ToList();
            List<string> newDeckOfCards = new List<string>();
            string command = Console.ReadLine();
            string cardName = string.Empty;
            string cardTwo = string.Empty;
            int indexOfCard = 0;
            while (command != "Ready")
            {
                List<string> tokens = command.Split().ToList();
                if (tokens[0] == "Add")
                {
                    cardName = tokens[1];
                    AddCard(deckOfCards, newDeckOfCards, cardName);
                }
                if (tokens[0] == "Insert")
                {
                    cardName = tokens[1];
                    indexOfCard = int.Parse(tokens[2]);
                    InsertCard(deckOfCards, newDeckOfCards, cardName, indexOfCard);
                }
                if (tokens[0] == "Remove")
                {
                    cardName = tokens[1];
                    RemoveCard(newDeckOfCards, cardName);
                }
                if (tokens[0] == "Swap")
                {
                    cardName = tokens[1];
                    cardTwo = tokens[2];
                    SwapCard(newDeckOfCards, cardName, cardTwo);
                }
                if (tokens[0] == "Shuffle" && tokens[1] == "deck")
                {
                    newDeckOfCards.Reverse();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", newDeckOfCards));
        }
        static void SwapCard(List<string> newDeckOfCards, string cardNames, string cardTwo)
        {
            int firstCard = newDeckOfCards.IndexOf(cardNames);
            int secondCard = newDeckOfCards.IndexOf(cardTwo);
            string first = cardTwo;
            string second = cardNames;
            newDeckOfCards[firstCard] = first;
            newDeckOfCards[secondCard] = second;

        }
        static void RemoveCard(List<string> newDeckOfCards, string cardNames)
        {
            bool isCardContainInDeck = newDeckOfCards.Contains(cardNames);
            if (isCardContainInDeck)
            {
                newDeckOfCards.Remove(cardNames);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }
        static void AddCard(List<string> deckOfCards, List<string> newDeckOfCards, string cardNames)
        {
            string newCard = string.Empty;
            bool isCardContainInDeck = deckOfCards.Contains(cardNames);
            if (isCardContainInDeck)
            {
                newCard = cardNames;
                newDeckOfCards.Add(newCard);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }
        static void InsertCard(List<string> deckOfCards, List<string> newDeckOfCards, string cardNames, int indexOfCard)
        {
            bool isCardContainInDeck = deckOfCards.Contains(cardNames);
            if (isCardContainInDeck && indexOfCard < newDeckOfCards.Count && indexOfCard >= 0)
            {
                newDeckOfCards.Insert(indexOfCard, cardNames);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
