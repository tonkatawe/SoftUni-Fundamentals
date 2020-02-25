using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputBooks = Console.ReadLine().Split('&').ToList();
            var command = Console.ReadLine();
            var task = string.Empty;
            var firstBook = string.Empty;
            var secondBook = string.Empty;
            while (command != "Done")
            {
                var tokens = command.Split(" | ");
                task = tokens[0];
                firstBook = tokens[1];
                if (task == "Add Book" && !inputBooks.Contains(firstBook))
                {
                    inputBooks.Insert(0, firstBook);
                }
                else if (task == "Take Book" && inputBooks.Contains(firstBook))
                {
                    inputBooks.Remove(firstBook);
                }
                else if (task == "Insert Book")
                {
                    inputBooks.Add(firstBook);
                }
                else if (task == "Check Book")
                {
                    var indexOfBook = int.Parse(firstBook);
                    if (indexOfBook >= 0 && indexOfBook <= inputBooks.Count - 1)
                    {
                        Console.WriteLine(inputBooks[indexOfBook]);
                    }
                }
                else if (task == "Swap Books")
                {
                    secondBook = tokens[2];
                    if (inputBooks.Contains(firstBook) && inputBooks.Contains(secondBook))
                    {
                        for (int i = 0; i < inputBooks.Count; i++)
                        {
                            if (inputBooks[i] == firstBook)
                            {
                                inputBooks[i] = secondBook;
                            }
                            else if (inputBooks[i] == secondBook)
                            {
                                inputBooks[i] = firstBook;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", inputBooks));
        }
    }
}

