using System;
using System.Linq;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weaponParts = Console.ReadLine().Split("|").ToArray();
            string[] command = Console.ReadLine().Split().ToArray();
            int index = 0;
            while (command[0] != "Done")
            {
                if (command[1] == "Left")
                {
                    index = int.Parse(command[2]);
                    MoveLeft(weaponParts, index);
                }
                if (command[1] == "Right")
                {
                    index = int.Parse(command[2]);
                    MoveRight(weaponParts, index);
                }
                if (command[1] == "Even")
                {
                    CheckEven(weaponParts);
                }
                if (command[1] == "Odd")
                {
                    CheckOdd(weaponParts);
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.Write("You crafted ");
            for (int i = 0; i < weaponParts.Length; i++)
            {
                Console.Write(weaponParts[i]);
            }
            Console.Write("!");
        }
        static void MoveLeft(string[] command, int index)
        {
            if (index < command.Length)
            {

                for (int i = 0; i < command.Length; i++)
                {
                    if (index == 0)
                    {
                        continue;
                    }
                    if (i == index)
                    {
                        string current = command[i - 1];
                        command[i - 1] = command[i];
                        command[i] = current;
                    }
                }
            }
        }
        static void MoveRight(string[] command, int index)
        {
            if (index < command.Length)
            {

                for (int i = 0; i < command.Length; i++)
                {
                    if (i == command.Length - 1)
                    {
                        continue;
                    }
                    if (i == index)
                    {
                        string current = command[i + 1];
                        command[i + 1] = command[i];
                        command[i] = current;
                    }
                }
            }
        }
        static void CheckEven(string[] command)
        {
            for (int i = 0; i < command.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(command[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void CheckOdd(string[] command)
        {
            for (int i = 0; i < command.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(command[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
