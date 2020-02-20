using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int valueInt;
            float valueFloat;
            char valueChar;
            bool valueBool;

            while (command != "END")
            {


                if (int.TryParse(command, out valueInt))
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (float.TryParse(command, out valueFloat))
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (char.TryParse(command, out valueChar))
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if (bool.TryParse(command, out valueBool))
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }

                command = Console.ReadLine();
            }
        }
    }
}
