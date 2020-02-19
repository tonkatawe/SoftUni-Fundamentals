using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = hours * 60 + minutes + 30;
            hours = minutes / 60;
            minutes = minutes % 60;
            if (hours > 23)
            {
                hours = 0;
            }
            if (minutes < 10)
            {

                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {

                Console.WriteLine($"{hours}:{minutes}");

            }
        }
    }
}
