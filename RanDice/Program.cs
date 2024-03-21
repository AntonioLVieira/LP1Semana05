using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Uso: dotnet run --project RanDice -- <número_de_dados> <semente>");
                return;
            }

            if (!int.TryParse(args[0], out int numberOfDice) || !int.TryParse(args[1], out int seed))
            {
                Console.WriteLine("Os argumentos não são válidos.");
                return;
            }

            Random random = new Random(seed);
            int sum = 0;

            for (int i = 0; i < numberOfDice; i++)
            {
                int diceValue = random.Next(1, 7); 
                sum += diceValue;
            }

            Console.WriteLine(sum);
        }
    }
}