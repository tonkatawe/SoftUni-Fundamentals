using System;
using System.Linq;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetOfArchery = Console.ReadLine().Split('|').Select(int.Parse).ToArray();
            var command = Console.ReadLine();
            var points = 0;
            var startIndex = 0;
            var lenghtOfMovement = 0;
            string[] tokens;
            while (command != "Game over")
            {
                if (command == "Reverse")
                {
                    Array.Reverse(targetOfArchery);
                    command = Console.ReadLine();
                    continue;
                }
                tokens = command.Split(new string[] { " ", "@" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens[1] == "Right")
                {
                    startIndex = int.Parse(tokens[2]);
                    lenghtOfMovement = int.Parse(tokens[3]);
                    if (startIndex >= 0 && startIndex <= targetOfArchery.Length - 1)
                    {
                        while (lenghtOfMovement != 0)
                        {
                            if (startIndex < targetOfArchery.Length - 1)
                            {
                                startIndex++;
                                lenghtOfMovement--;
                            }
                            else if (startIndex == targetOfArchery.Length - 1)
                            {
                                startIndex = 0;
                                lenghtOfMovement--;
                            }
                        }
                        if (targetOfArchery[startIndex] >= 5)
                        {
                            targetOfArchery[startIndex] -= 5;
                            points += 5;
                        }
                        else
                        {
                            points += targetOfArchery[startIndex];
                            targetOfArchery[startIndex] = 0;
                        }
                    }
                }
                else if (tokens[1] == "Left")
                {
                    startIndex = int.Parse(tokens[2]);
                    lenghtOfMovement = int.Parse(tokens[3]);
                    if (startIndex >= 0 && startIndex <= targetOfArchery.Length - 1)
                    {
                        while (lenghtOfMovement != 0)
                        {
                            if (startIndex > 0)
                            {
                                startIndex--;
                                lenghtOfMovement--;
                            }
                            else if (startIndex == 0)
                            {
                                startIndex = targetOfArchery.Length - 1;
                                lenghtOfMovement--;
                            }
                        }
                        if (targetOfArchery[startIndex] >= 5)
                        {
                            targetOfArchery[startIndex] -= 5;
                            points += 5;
                        }
                        else
                        {
                            points += targetOfArchery[startIndex];
                            targetOfArchery[startIndex] = 0;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" - ", targetOfArchery));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}



