using System;
using System.Linq;

namespace _01._String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var someText = Console.ReadLine();

            while (true)
            {
                var tokens = Console.ReadLine().Split().ToArray(); //use tokens[0] such a instruction to action
                if (tokens[0] == "Change")
                {
                    var currentChar = tokens[1];
                    var newChar = tokens[2];
                    if (someText.Contains(currentChar))
                    {
                        someText = someText.Replace(currentChar, newChar);
                        Console.WriteLine(someText);
                    }


                }
                else if (tokens[0] == "Includes")
                {
                    var currentString = tokens[1];
                    if (someText.Contains(currentString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (tokens[0] == "End")
                {
                    var currentString = tokens[1];
                    var index = currentString.Length;
                    if (index < someText.Length)
                    {

                        var temp = someText.Substring(someText.Length - 1 - index+1);
                        if (temp == currentString)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }

                }
                else if (tokens[0] == "Uppercase")
                {
                    someText = someText.ToUpper();
                    Console.WriteLine(someText);
                }
                else if (tokens[0] == "FindIndex")
                {
                    var currentChar = char.Parse(tokens[1]);
                    var temp = someText.ToCharArray();
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (temp[i] == currentChar)
                        {
                            Console.WriteLine(i);
                            break;
                        }

                    }

                }
                else if (tokens[0] == "Cut")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var lenght = int.Parse(tokens[2]);

                    if (startIndex >=0 && startIndex < someText.Length && lenght >= 0 && lenght > startIndex && lenght < someText.Length)
                    {
                        someText = someText.Substring(startIndex, lenght);
                        Console.WriteLine(someText);
                        
                    }
                    

                }
                else if (tokens[0] == "Done")
                {
                    break;
                }
            }
        }
    }
}
