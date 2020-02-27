using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Easter_Shopping
{
    class Program
    {// 80/100 check
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split(" ").ToList();
            var numberOfCommand = int.Parse(Console.ReadLine());
            if (numberOfCommand < 0)
            {
                return;
            }
            for (int i = 0; i < numberOfCommand; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                var instruction = tokens[0];
                if (instruction == "Include") //it can be possible to check contains of list
                {
                    var shop = tokens[1];
                    shops.Add(shop);
                }
                else if (instruction == "Visit")
                {
                    var command = tokens[1];
                    if (command == "first")
                    {
                        var index = int.Parse(tokens[2]);
                        if (index >= 0 && index < shops.Count)
                        {
                            shops.RemoveRange(0, index);
                        }
                    }
                    else if (command == "last")
                    {
                        var index = int.Parse(tokens[2]);
                        if (index >= 0 && index < shops.Count)
                        {
                            shops.Reverse();
                            shops.RemoveRange(0, index);
                            shops.Reverse();
                        }

                    }

                }
                else if (instruction == "Prefer")
                {
                    var index = int.Parse(tokens[1]);
                    var indexTwo = int.Parse(tokens[2]);
                    if (index >= 0 && indexTwo >= 0 && index < shops.Count - 1 && indexTwo < shops.Count - 1)
                    {
                        var firstShop = shops[index];
                        var secondShop = shops[indexTwo];
                        for (int k = 0; k < shops.Count; k++)
                        {
                            if (shops[k] == firstShop)
                            {
                                shops[k] = secondShop;
                            }
                            else if (shops[k] == secondShop)
                            {
                                shops[k] = firstShop;
                            }
                        }
                    }
                }
                else if (instruction == "Place")
                {
                    var shop = tokens[1];
                    var index = int.Parse(tokens[2]);
                    index = index + 1;
                    if (index >= 0 && index <= shops.Count - 1) //can be possible to make check for contains
                    {
                        shops.Insert(index, shop);
                    }
                }
            }
            Console.WriteLine($"Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
