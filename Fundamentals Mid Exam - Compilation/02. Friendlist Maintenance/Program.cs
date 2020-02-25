using System;
using System.Linq;
namespace _02._Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ").ToArray();
            string[] input = Console.ReadLine().Split().ToArray();
            string name = string.Empty;
            int index = 0;
            int countBlackList = 0;
            int countLost = 0;

            while (input[0] != "Report")
            {
                if (input[0] == "Blacklist")
                {
                    name = input[1];
                    Blacklist(names, name);
                    countBlackList++;
                }
                if (input[0] == "Error")
                {
                    index = int.Parse(input[1]);
                    if (index <= names.Length - 1 && index >= 0)
                    {
                        if (names[index] != "Blacklisted" && names[index] != "Lost")
                        {
                            name = names[index];
                            names[index] = "Lost";
                            Console.WriteLine($"{name} was lost due to an error.");
                            countLost++;
                        }

                    }
                }
                if (input[0] == "Change")
                {
                    index = int.Parse(input[1]);
                    if (index <= names.Length - 1 && index >= 0)
                    {
                        name = input[2];
                        Change(names, name, index);
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"Blacklisted names: {countBlackList}");
            Console.WriteLine($"Lost names: {countLost}");
            Console.WriteLine(string.Join(" ", names));


        }
        static void Blacklist(string[] command, string name)
        {
            bool includename = false;
            int index = 0;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == name)
                {
                    includename = true;
                    index = i;
                    break;
                }
            }
            if (includename)
            {
                command[index] = "Blacklisted";
                Console.WriteLine($"{name} was blacklisted.");
            }
            else
            {
                Console.WriteLine($"{name} was not found.");
            }
        }
        static void Change(string[] command, string name, int index)
        {
            if (index >= 0 && index < command.Length)
            {
                string currentName = command[index];
                for (int i = 0; i < command.Length; i++)
                {
                    command[index] = name;
                }
                Console.WriteLine($"{currentName} changed his username to {name}.");
            }
        }
        static void Error(string[] names, int index)
        {
            if (index < names.Length && index >= 0)
            {
                string name = string.Empty;
                if (names[index] != "Blacklisted" && names[index] != "Lost")
                {
                    name = names[index];
                    names[index] = "Lost";
                    Console.WriteLine($"{name} was lost due to an error.");

                }
            }
        }

    }
}
