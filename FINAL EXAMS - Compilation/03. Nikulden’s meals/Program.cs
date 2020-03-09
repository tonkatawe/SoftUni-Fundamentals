using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guestAndMeals = new Dictionary<string, List<string>>();
            var unlikeDishesCounter = 0;
            while (true)
            {
                var command = Console.ReadLine();
                var tokens = command.Split('-');
                if (tokens[0] == "Like")
                {
                    var guest = tokens[1];
                    var meal = tokens[2];
                    if (!guestAndMeals.ContainsKey(guest))
                    {
                        guestAndMeals.Add(guest, new List<string>());
                        guestAndMeals[guest].Add(meal);
                    }
                    else if (guestAndMeals.ContainsKey(guest) && !guestAndMeals[guest].Contains(meal))
                    {
                        guestAndMeals[guest].Add(meal);
                    }
                }
                else if (tokens[0] == "Unlike")
                {
                    var guest = tokens[1];
                    var meal = tokens[2];
                    if (guestAndMeals.ContainsKey(guest) && guestAndMeals[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        guestAndMeals[guest].Remove(meal);
                        unlikeDishesCounter++;
                    }
                    else if (guestAndMeals.ContainsKey(guest) && !guestAndMeals[guest].Contains(meal))

                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else if (!guestAndMeals.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }
                else if (tokens[0] == "Stop")
                {
                    break;
                }

            }
            foreach (var guest in guestAndMeals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikeDishesCounter}");
        }
    }
}
