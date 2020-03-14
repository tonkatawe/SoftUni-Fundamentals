using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Battle_Manager
{
    class Program
    {
        // check 91/100
        static void Main(string[] args)
        {
            Dictionary<string, int> userAndHealth = new Dictionary<string, int>();
            Dictionary<string, int> userAndEnergy = new Dictionary<string, int>();
            while (true)
            {
                var tokens = Console.ReadLine().Split(':');
                var command = tokens[0];
                if (command == "Add")
                {
                    var username = tokens[1];
                    var health = int.Parse(tokens[2]);
                    var energy = int.Parse(tokens[3]);
                    if (health > 0 && energy > 0)
                    {
                        if (!userAndHealth.ContainsKey(username))
                        {
                            userAndHealth.Add(username, health);
                            userAndEnergy.Add(username, energy);
                        }
                        else
                        {
                            userAndHealth[username] += health;
                        }
                    }
                }
                else if (command == "Attack")
                {
                    var attackerName = tokens[1];
                    var defenderName = tokens[2];
                    var damage = int.Parse(tokens[3]);
                    if (userAndHealth.ContainsKey(attackerName) && userAndHealth.ContainsKey(defenderName) && damage > 0)
                    {
                        userAndHealth[defenderName] -= damage;
                        userAndEnergy[attackerName] -= 1;
                        if (userAndHealth[defenderName] <= 0)
                        {
                            Console.WriteLine($"{defenderName} was disqualified!");
                            userAndEnergy.Remove(defenderName);
                            userAndHealth.Remove(defenderName);
                        }
                        if (userAndEnergy[attackerName] <= 0) //here might be need to chek with <=
                        {
                            Console.WriteLine($"{attackerName} was disqualified!");
                            userAndEnergy.Remove(attackerName);
                            userAndHealth.Remove(attackerName);
                        }
                    }
                }
                else if (command == "Delete")
                {
                    var username = tokens[1];
                    if (userAndHealth.ContainsKey(username))
                    {
                        userAndHealth.Remove(username);
                        userAndEnergy.Remove(username);
                    }
                    else if (username == "All")
                    {
                        userAndEnergy.Clear();
                        userAndHealth.Clear();
                    }
                }
                else if (command == "Results")
                {
                    break;
                }
            }

            Console.WriteLine($"People count: {userAndHealth.Count}");
            foreach (var user in userAndHealth.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value} - {userAndEnergy[user.Key]}");
            }
        }
    }
}
