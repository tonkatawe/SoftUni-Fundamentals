using System;
using System.Linq;
namespace _02._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gifts = Console.ReadLine().Split(' ');
            var command = Console.ReadLine();
            while (command != "No Money")
            {
                var tokens = command.Split();
                var instruction = tokens[0];
                if (instruction == "OutOfStock")
                {
                    var gift = tokens[1];
                    for (int i = 0; i < gifts.Length; i++)
                    {
                        if (gifts[i] == gift)
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (instruction == "Required")
                {
                    var gift = tokens[1];
                    var index = int.Parse(tokens[2]);
                    if (index >= 0 && index <= gifts.Length-1)
                    {
                        gifts[index] = gift;
                        //for (int i = 0; i < gifts.Length; i++)
                        //{
                        //    if (i == index)
                        //    {
                        //        gifts[i] = gift;
                        //    }
                        //}
                    }

                }
                else if (instruction == "JustInCase")
                {
                    var gift = tokens[1];
                    gifts[gifts.Length - 1] = gift;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", gifts.Where(x=> x != "None")));
        }
    }
}
