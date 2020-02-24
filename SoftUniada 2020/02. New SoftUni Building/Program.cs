using System;

namespace _02._New_SoftUni_Building
{
    class Program
    {
            //  #...#
            //  ...#.
            //  ..#..
            //  .#...
            //  #...#
            //  ...#.
            //  ..#..

        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            string seat = "#";
            string empty = ".";
            var counter = 0;
            Console.Write(seat);
            for (int i = 0; i < input; i++)
            {
                
             
                for (int k = 0; k <= input; k++)
                {
                    Console.Write(empty);
                    counter++;
                    if (counter == 3)
                    {
                        Console.WriteLine(seat);
                        counter = 0;
                    }
                }
            //    counter = 0;
              //  Console.WriteLine();
            }
        }
    }
}
