using System;

namespace _01._Biscuits_Factory
{
    class Program
    {
        //pass for mid Exam - chill_out
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workersInFactory = int.Parse(Console.ReadLine());
            int biscuitsOfAnotherFactory = int.Parse(Console.ReadLine());
            int counter = 0;
            double sumPerDay = 0;

            for (int i = 0; i < 30; i++)
            {
                counter++;
                if (counter == 3)
                {
                    counter = 0;
                    sumPerDay += Math.Floor(0.75 * biscuitsPerDay * workersInFactory);
                }
                else
                {
                    sumPerDay += biscuitsPerDay * workersInFactory;
                }
            }
            double coucountBiscuits = (int)sumPerDay;
            Console.WriteLine($"You have produced {coucountBiscuits} biscuits for the past month.");

            double percent = Math.Abs((coucountBiscuits - biscuitsOfAnotherFactory) * 100 / biscuitsOfAnotherFactory);
            if (coucountBiscuits > biscuitsOfAnotherFactory)
            {
                Console.WriteLine($"You produce {percent:F2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percent:F2} percent less biscuits.");
            }

        }
    }
}
