using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar e instanciar dois cronómetros diferentes
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            // O 1º cronómetro começa a contar o tempo
            crono1.Start();

            // O 1º cronómetro pausa durante meio segundo
            Thread.Sleep(500);

            // O 2º cronómetro começa a contar o tempo
            crono2.Start();

            // O 2º cronómetro pausa durante o.3 segundos
            Thread.Sleep(300);

            // Ambos os crónometros param de contar o tempo
            crono1.Stop();
            crono2.Stop();

            // Converte os números double para segundos e dá os números da referência 
            double number1 = crono1.Elapsed.TotalSeconds;
            double number2 = crono2.Elapsed.TotalSeconds;

            // Converte os números double para string e apresenta na consola o tempo de cada cronómetro com 2 casas décimais
            Console.WriteLine("O Tempo decorrido do cronometro 1 é de " + number1.ToString("F2") + " segundos.");
            Console.WriteLine("O Tempo decorrido do cronometro 2 é de " + number2.ToString("F2") + " segundos.");
        }
    }
}
