using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();
            for (int i = 0; i < numbersOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                string command = tokens[0];
                string username = tokens[1];
                string licensePlateNumber = string.Empty;
                if (tokens.Length > 2)
                {
                    licensePlateNumber = tokens[2];
                }
                switch (command)
                {
                    case "register":
                        if (registeredUsers.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                            continue;
                        }
                        registeredUsers[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        break;
                    case "unregister":
                        if (!registeredUsers.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                            continue;
                        }
                        Console.WriteLine($"{username} unregistered successfully");
                        registeredUsers.Remove(username);
                        break;
                    default:
                        break;
                }

            }
            foreach (var users in registeredUsers)
            {
                Console.WriteLine($"{users.Key} => {users.Value}");
            }

        }

    }
}
