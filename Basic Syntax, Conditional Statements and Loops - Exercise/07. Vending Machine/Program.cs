namespace MySandBox
{
    using System;

    public class StartUp
    {
        public static void Main()
        {

            double totalCoinsInserted = 0.0D;

            while (true)
            {
                string inputArg = Console.ReadLine();

                if (inputArg == "Start")
                    break;

                double currentInsertedCoins = double.Parse(inputArg);

                switch (currentInsertedCoins)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 0.8:
                    case 1.0:
                    case 2.0:
                        totalCoinsInserted += currentInsertedCoins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {currentInsertedCoins}");
                        break;
                }
            }

            double receiptTotal = 0.0D;

            while (true)
            {
                string inputArg = Console.ReadLine();

                if (inputArg == "End")
                    break;

                double currentArticlePrice = 0.0D;

                switch (inputArg)
                {
                    case "Nuts":
                        currentArticlePrice = 2.0D;
                        break;
                    case "Water":
                        currentArticlePrice = 0.7D;
                        break;
                    case "Crisps":
                        currentArticlePrice = 1.5D;
                        break;
                    case "Soda":
                        currentArticlePrice = 0.8D;
                        break;
                    case "Coke":
                        currentArticlePrice = 1.0D;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                }

                if (totalCoinsInserted < currentArticlePrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                else
                {
                    totalCoinsInserted -= currentArticlePrice;
                    Console.WriteLine($"Purchased {inputArg.ToLower()}");
                }
            }

            Console.WriteLine($"Change: {totalCoinsInserted:F2}");
        }
    }
}
