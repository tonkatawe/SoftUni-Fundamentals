using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double saving = double.Parse(Console.ReadLine()); //saving of Gabsy
            List<int> drumSets = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> backUpDrum = new List<int>(drumSets);
            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {
                int powers = int.Parse(command);
                for (int i = 0; i < drumSets.Count; i++)
                {
                    drumSets[i] -= powers;
                    if (drumSets[i] <= 0 && backUpDrum[i] * 3 <= saving)
                    {
                        drumSets[i] = backUpDrum[i];
                        saving -= backUpDrum[i] * 3;
                    }
                    else if (drumSets[i] <= 0 && backUpDrum[i] * 3 > saving)
                    {
                        drumSets.RemoveAt(i);
                        backUpDrum.RemoveAt(i);
                        i--;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", drumSets));
            Console.WriteLine($"Gabsy has {saving:F2}lv.");


        }
    }
}
