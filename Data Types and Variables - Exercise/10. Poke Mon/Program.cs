using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int pokeTargetsM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            decimal remainedN = pokePowerN;
            int countOfTargets = 0;
            int half = pokePowerN / 2;
            while (remainedN >= pokeTargetsM)
            {
                if (remainedN == half && exhaustionFactorY > 0)
                {

                    remainedN = (int)remainedN / exhaustionFactorY;
                    continue;
                }

                remainedN = remainedN - pokeTargetsM;
                countOfTargets++;
            }
            Console.WriteLine(remainedN);
            Console.WriteLine(countOfTargets);
        }
    }
}
