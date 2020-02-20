using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] newWagons = command.Split();
                if (newWagons[0] == "Add")
                {
                    wagons.Add(int.Parse(newWagons[1]));
                }
                else
                {
                    int currentPassenger = int.Parse(newWagons[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((maxCapacityOfWagon - wagons[i]) >= currentPassenger)
                        {
                            wagons[i] = wagons[i] + currentPassenger;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
