using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the number of dices: ");
            int dices = int.Parse(Console.ReadLine());
            Random number = new Random();
            int sum = 0;
            for (int i = 0; i < dices; i++)
            {
                int dice = number.Next(1,7);
                sum = sum + dice;
            }
            Console.WriteLine("The sum of all the results from the dices is: " + sum);

        }
    }
}
