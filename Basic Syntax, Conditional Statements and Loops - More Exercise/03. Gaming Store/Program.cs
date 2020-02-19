using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double balance = currentBalance;
            double decreaseBalance = 0;

            while (command != "Game Time")
            {
                if (command != "OutFall 4" && command != "CS: OG" && command != "Zplinter Zell" && command != "Honored 2" && command != "RoverWatch" && command != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                    command = Console.ReadLine();
                }
                if (command == "OutFall 4")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        // command = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        decreaseBalance = balance - 39.99;
                        balance = decreaseBalance;
                    }
                    if (balance <= 0)
                    {

                        break;
                    }
                }
                if (command == "CS: OG")
                {
                    if (balance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                        // command = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        decreaseBalance = balance - 15.99;
                        balance = decreaseBalance;
                    }
                    if (balance <= 0)
                    {

                        break;
                    }
                }
                if (command == "Zplinter Zell")
                {
                    if (balance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                        // command = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        decreaseBalance = balance - 19.99;
                        balance = decreaseBalance;
                    }
                    if (balance <= 0)
                    {

                        break;
                    }
                }
                if (command == "Honored 2")
                {
                    if (balance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                        //command = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        decreaseBalance = balance - 59.99;
                        balance = decreaseBalance;
                    }
                    if (balance <= 0)
                    {

                        break;
                    }
                }
                if (command == "RoverWatch")
                {
                    if (balance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                        //  command = Console.ReadLine();

                    }
                    else
                    {
                        decreaseBalance = balance - 29.99;
                        balance = decreaseBalance;
                        Console.WriteLine($"Bought {command}");
                    }
                    if (balance <= 0)
                    {

                        break;
                    }
                }
                if (command == "RoverWatch Origins Edition")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        // command = Console.ReadLine();
                    }
                    else
                    {
                        decreaseBalance = balance - 39.99;
                        balance = decreaseBalance;
                        Console.WriteLine($"Bought {command}");
                    }
                    if (balance <= 0)
                    {
                        break;
                    }
                }
                command = Console.ReadLine();

            }
            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            if (command == "Game Time" && balance > 0)
            {
                double spent = currentBalance - decreaseBalance;
                Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${balance:F2}");
            }
        }
    }
}
