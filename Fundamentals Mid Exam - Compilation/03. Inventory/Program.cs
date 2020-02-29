using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> itemsInInventory = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();
            while (command != "Craft!")
            {
                string[] tokens = command.Split(" - ");
                string insturction = tokens[0];
                if (insturction == "Collect")
                {
                    var item = tokens[1];
                    if (!itemsInInventory.Contains(item))
                    {
                        itemsInInventory.Add(item);
                    }
                }
                else if (insturction == "Drop")
                {
                    var item = tokens[1];
                    if (itemsInInventory.Contains(item))
                    {
                        itemsInInventory.Remove(item);
                    }
                }
                else if (insturction == "Combine Items")
                {
                    var combineItems = tokens[1].Split(':');
                    var oldItems = combineItems[0];
                    var newItems = combineItems[1];
                    if (itemsInInventory.Contains(oldItems))
                    {
                       var index = itemsInInventory.IndexOf(oldItems);
                        itemsInInventory.Insert(index + 1, newItems); 
                    }
                }
                else if (insturction == "Renew")
                {
                    var item = tokens[1];
                    if (itemsInInventory.Contains(item))
                    {
                        var temp = item;
                        itemsInInventory.Remove(item);
                        itemsInInventory.Add(temp);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", itemsInInventory));
        }
    }
}
