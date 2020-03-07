using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Warrior_s_Quest
{
    //60/100 have to check
    class Program
    {
        static void Main(string[] args)
        {
            string result = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "For Azeroth")
            {
                var tokens = command.Split(" ");
                var text = tokens[0];
                if (text == "GladiatorStance")
                {
                    result = result.ToUpper();
                    Console.WriteLine(result);
                }
                else if (text == "DefensiveStance")
                {
                    result = result.ToLower();
                    Console.WriteLine(result);
                }
                else if (text == "Dispel")
                {

                    var index = int.Parse(tokens[1]);
                    char letter = char.Parse(tokens[2]);
                    if (index < result.Length && index >= 0)
                    {
                        char[] temp = result.ToCharArray();
                        temp[index] = letter;
                        result = new string(temp);

                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }
                else if (text == "Target")
                {
                    if (tokens[1] == "Change") // might be have to check contains
                    {
                        var substring = tokens[2];
                        var substringNew = tokens[3];
                        if (result.Contains(substring))
                        {
                            result = result.Replace(substring, substringNew);
                            Console.WriteLine(result);
                        }
                    }
                    else if (tokens[1] == "Remove")
                    {
                        var substring = tokens[2];
                        if (result.Contains(substring))
                        {
                            var index = result.IndexOf(substring);
                            result = result.Remove(index, substring.Length);
                            Console.WriteLine(result);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
                command = Console.ReadLine();
            }

        }
    }
}
