using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, double> totalPrice = new Dictionary<string, double>();
            Dictionary<string, double> quantityDict = new Dictionary<string, double>();

            while (command != "buy")
            {
                var tokens = command.Split();
                string productName = tokens[0];
                double price = double.Parse(tokens[1]);
                double quantity = double.Parse(tokens[2]);
                if (totalPrice.ContainsKey(productName))
                {
                    totalPrice[productName] = (quantityDict[productName] + quantity) * price;
                    quantityDict[productName] += quantity;

                }
                else
                {
                    totalPrice.Add(productName, quantity * price);
                    quantityDict.Add(productName, quantity);
                }
                command = Console.ReadLine();

            }
            foreach (var item in totalPrice)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }

    }
}
