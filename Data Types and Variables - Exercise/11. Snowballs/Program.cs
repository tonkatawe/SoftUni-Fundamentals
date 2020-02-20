using System;
using System.Numerics;


namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfSnowballs = sbyte.Parse(Console.ReadLine());
            short snowballSnow = 0;
            short snowballTime = 0;
            sbyte snowballQuality = 0;
            BigInteger snowballValue = 0;
            BigInteger max = 0;
            short one = 0;
            short two = 0;
            sbyte three = 0;
            for (sbyte i = 0; i < numberOfSnowballs; i++)
            {
                snowballSnow = short.Parse(Console.ReadLine());
                snowballTime = short.Parse(Console.ReadLine());
                snowballQuality = sbyte.Parse(Console.ReadLine());
                snowballValue = (BigInteger)Math.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > max)
                {
                    max = snowballValue;
                    one = snowballSnow;
                    two = snowballTime;
                    three = snowballQuality;
                }
            }
            Console.WriteLine($"{one} : {two} = {max} ({three})");
        }
    }
}
