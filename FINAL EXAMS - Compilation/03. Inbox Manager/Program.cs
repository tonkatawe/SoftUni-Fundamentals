using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> usersAndMsg = new Dictionary<string, List<string>>();
            while (true)
            {
                var tokens = Console.ReadLine().Split("->");
                if (tokens[0] == "Add")
                {
                    var username = tokens[1];
                    if (!usersAndMsg.ContainsKey(username))
                    {
                        usersAndMsg.Add(username, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                }
                else if (tokens[0] == "Send")
                {
                    var username = tokens[1];
                    var email = tokens[2];
                    if (usersAndMsg.ContainsKey(username))
                    {
                        usersAndMsg[username].Add(email);
                    }
                }
                else if (tokens[0] == "Delete")
                {
                    var username = tokens[1];
                    if (usersAndMsg.ContainsKey(username))
                    {
                        usersAndMsg.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
                else if (tokens[0] == "Statistics")
                {
                    break;
                }
            }
            var count = usersAndMsg.Count;
            Console.WriteLine($"Users count: {count}");
            foreach (var user in usersAndMsg.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var email in user.Value)
                {
                    Console.WriteLine($" - {email}");
                }
            }
        }
    }
}
