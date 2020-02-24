using System;

namespace _02._Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                int l = int.Parse(Console.ReadLine());


                for (int firstSymbol = 1; firstSymbol <= n; firstSymbol++)
                {
                    for (int secondSymbol = 1; secondSymbol <= n; secondSymbol++)
                    {
                        for (char thirdSymbol = 'a'; thirdSymbol < 'a' + l; thirdSymbol++)
                        {
                            for (char fourthSymbol = 'a'; fourthSymbol < 'a' + l; fourthSymbol++)
                            {
                                int lastSymbol = 0;
                                if (firstSymbol > secondSymbol)
                                {
                                    lastSymbol = firstSymbol + 1;
                                }
                                else
                                {
                                    lastSymbol = secondSymbol + 1;
                                }
                                for (int fifthSymbol = lastSymbol; fifthSymbol <= n; fifthSymbol++)
                                {
                                    Console.Write($"{firstSymbol}{secondSymbol}{thirdSymbol}{fourthSymbol}{fifthSymbol} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
