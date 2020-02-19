using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = string.Empty;
            int counter = 1;
            char[] cArray = username.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            pass = reverse;
            string command = Console.ReadLine();
            while (command != pass)
            {
                Console.WriteLine("Incorrect password. Try again.");
                command = Console.ReadLine();
                counter++;
                if (counter == 4)
                {
                    break;
                }

            }
            if (command == pass)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            if (counter >= 4)

            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
