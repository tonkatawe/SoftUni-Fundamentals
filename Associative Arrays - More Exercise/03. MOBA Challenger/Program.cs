using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> usersPossitionAndPoints = new Dictionary<string, Dictionary<string, int>>();
            while (command != "Season end")
            {
                if (command.Contains("-"))
                {
                    string[] tokens = command.Split(" -> ");
                    string player = tokens[0];
                    string possition = tokens[1];
                    int skills = int.Parse(tokens[2]);
                    if (!usersPossitionAndPoints.ContainsKey(player))
                    {
                        usersPossitionAndPoints[player] = new Dictionary<string, int>();
                        usersPossitionAndPoints[player].Add(possition, skills);
                    }
                    else
                    {
                        if (!usersPossitionAndPoints[player].ContainsKey(possition))
                        {
                            usersPossitionAndPoints[player].Add(possition, skills);
                        }
                        if (usersPossitionAndPoints[player][possition] <= skills)
                        {
                            usersPossitionAndPoints[player][possition] = skills;
                        }
                    }

                }
                if (command.Contains("vs"))
                {
                    bool playerOneWin = false;
                    bool playerTwoWin = false;
                    string[] tokens = command.Split(" vs ");
                    string playerOne = tokens[0];
                    string playerTwo = tokens[1];
                    if (usersPossitionAndPoints.ContainsKey(playerOne) && usersPossitionAndPoints.ContainsKey(playerTwo))
                    {
                        foreach (var userOne in usersPossitionAndPoints[playerOne].Keys)
                        {
                            foreach (var userTwo in usersPossitionAndPoints[playerTwo].Keys)
                            {
                                if (userOne == userTwo && usersPossitionAndPoints[playerOne][userOne] > usersPossitionAndPoints[playerTwo][userTwo])
                                {
                                    playerOneWin = true;
                                }
                                if (userOne == userTwo && usersPossitionAndPoints[playerTwo][userTwo] > usersPossitionAndPoints[playerOne][userOne])
                                {
                                    playerTwoWin = true;
                                }
                            }
                        }
                        if (playerOneWin)
                        {
                            usersPossitionAndPoints.Remove(playerTwo);
                        }
                        if (playerTwoWin)
                        {
                            usersPossitionAndPoints.Remove(playerOne);
                        }

                    }

                }
                command = Console.ReadLine();
            }
            foreach (var user in usersPossitionAndPoints.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} skill");
                foreach (var possition in user.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {possition.Key} <::> {possition.Value}");
                }
            }
        }
    }

}
