using System;
using System.Collections.Generic;
using System.Linq;



namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                if (command == "3:1")
                {
                    break;
                }

                string contactWord = string.Empty;
                int indexOne = int.Parse(commands[1]);
                int indexTwo = int.Parse(commands[2]);
                if (indexTwo > input.Count - 1 || indexTwo < 0)
                {
                    indexTwo = input.Count - 1;
                }
                if (indexOne < 0 || indexOne > input.Count)
                {
                    indexOne = 0;
                }

                if (command == "merge")
                {
                    for (int i = indexOne; i <= indexTwo; i++)
                    {
                        contactWord += input[i];
                    }
                    input.RemoveRange(indexOne, indexTwo - indexOne + 1);
                    input.Insert(indexOne, contactWord);

                }
                else if (command == "divide")
                {
                    List<string> divided = new List<string>();
                    int divide = int.Parse(commands[2]);
                    string word = input[indexOne];
                    input.RemoveAt(indexOne);
                    int parts = word.Length / divide;
                    for (int i = 0; i < divide; i++)
                    {
                        if (i == divide - 1)
                        {
                            divided.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            divided.Add(word.Substring(i * parts, parts));
                        }
                    }
                    input.InsertRange(indexOne, divided);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}


