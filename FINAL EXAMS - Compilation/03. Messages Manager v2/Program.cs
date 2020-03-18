using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messages_Manager_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = int.Parse(Console.ReadLine());
            Dictionary<string, int> userSent = new Dictionary<string, int>();
            Dictionary<string, int> userReceived = new Dictionary<string, int>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Statistics")
                {
                    break;
                }
                var tokens = command.Split('=');
                var instruction = tokens[0];
                if (instruction == "Add")
                {
                    var username = tokens[1];
                    var sent = int.Parse(tokens[2]);
                    var received = int.Parse(tokens[3]);
                    if (!userSent.ContainsKey(username) && sent >= 0 && received >= 0)
                    {
                        userSent.Add(username, sent);
                        userReceived.Add(username, received);
                    }
                }
                else if (instruction == "Message")
                {
                    var sender = tokens[1];
                    var receiver = tokens[2];
                    if (userSent.ContainsKey(sender) && userReceived.ContainsKey(receiver))
                    {
                        userSent[sender] += 1;
                        userReceived[receiver] += 1;
                        if (userSent[sender] + userReceived[sender] == capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            userSent.Remove(sender);
                            userReceived.Remove(sender);

                        }

                        if (userSent[receiver] + userReceived[receiver] == capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            userSent.Remove(receiver);
                            userReceived.Remove(receiver);
                        }
                    }


                }
                else if (instruction == "Empty")
                {
                    var username = tokens[1];
                    if (userSent.ContainsKey(username) && userReceived.ContainsKey(username))
                    {
                        userSent.Remove(username);
                        userReceived.Remove(username);
                    }
                    else if (username == "All")
                    {
                        userSent.Clear();
                        userReceived.Clear();
                    }
                }

            }
            Console.WriteLine($"Users count: {userSent.Count}");
            foreach (var user in userReceived.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} - {userSent[user.Key] + userReceived[user.Key]}");
            }
        }
    }
}
