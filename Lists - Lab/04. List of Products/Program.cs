using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            string typeOfProducts = string.Empty;

            for (int i = 1; i <= numbersOfProducts; i++)
            {
                typeOfProducts = Console.ReadLine();
                products.Add(typeOfProducts);
            }
            products.Sort();
            for (int i = 0; i < numbersOfProducts; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");

            }
        }
    }
}
