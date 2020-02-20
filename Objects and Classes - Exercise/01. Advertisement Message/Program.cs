using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfMassagess = int.Parse(Console.ReadLine());
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            string[] results = new string[4];
            Random rnd = new Random();
            for (int i = 0; i < countOfMassagess; i++)
            {
                int tokens = rnd.Next(phrases.Length);
                results[0] = phrases[tokens];
                tokens = rnd.Next(events.Length);
                results[1] = events[tokens];
                tokens = rnd.Next(authors.Length);
                results[2] = authors[tokens];
                tokens = rnd.Next(cities.Length);
                results[3] = cities[tokens];
                Console.WriteLine($"{results[0]} {results[1]} {results[2]} - {results[3]}");

            }

        }
    }
}
