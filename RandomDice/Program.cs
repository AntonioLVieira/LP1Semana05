using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Peço ao utilizador o número de dados
            Console.Write("Give me the number of dices: ");

            // Converto o número de string para inteiro + Guardo o número do jogador numa variável
            int dices = int.Parse(Console.ReadLine());

            // Crio a instância (Random)
            Random number = new Random();
            int sum = 0;

            // Para cada dado faz isto: 
            for (int i = 0; i < dices; i++)
            {
                // Cria um valor aleatório de 1 a 6, para cada dado
                int dice = number.Next(1,7);

                // Soma o resultado de todos os dados
                sum = sum + dice;
            }

            // Escreve na consola a soma dos resultados dos dados
            Console.WriteLine("The sum of all the results from the dices is: " + sum);

        }
    }
}
