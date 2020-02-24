using System;
using System.Linq;
using System.Collections.Generic;
namespace _04._Swaps
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var dim = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                var n = dim[0];
                var m = dim[1];
                var matrix = new string[n, m];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    var a = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = a[j];
                    }
                }

                while (true)
                {
                    var commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (commands[0] == "swap")
                    {
                        if (commands.Length == 5)
                        {
                            var y1 = long.Parse(commands[1]);
                            var x1 = long.Parse(commands[2]);
                            var y2 = long.Parse(commands[3]);
                            var x2 = long.Parse(commands[4]);

                            if (!AreDimentionsValid(y1, x1, y2, x2, n, m))
                            {
                                Console.WriteLine("Invalid input!");
                                continue;
                            }
                            string tempValue = matrix[y1, x1];
                            matrix[y1, x1] = matrix[y2, x2];
                            matrix[y2, x2] = tempValue;

                            PrintMatrix(matrix);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }

                    }
                    else if (commands[0] == "END")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }
            }

            static bool AreDimentionsValid(long y1, long x1, long y2, long x2,
                long rowLength, long colLength)
            {
                bool areValid = true;

                if (x1 < 0 || x1 >= colLength)
                {
                    areValid = false;
                }
                else if (x2 < 0 || x2 >= colLength)
                {
                    areValid = false;
                }
                else if (y1 < 0 || y1 >= rowLength)
                {
                    areValid = false;
                }
                else if (y2 < 0 || y2 >= rowLength)
                {
                    areValid = false;
                }

                return areValid;
            }

            static void PrintMatrix(string[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}