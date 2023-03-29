using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(300);
            crono1.Stop();
            crono2.Stop();
            double number1 = crono1.Elapsed.TotalSeconds;
            double number2 = crono2.Elapsed.TotalSeconds;
            Console.WriteLine("O Tempo decorrido do cronometro 1 é de " + number1.ToString() + " segundos.");
            Console.WriteLine("O Tempo decorrido do cronometro 2 é de " + number2.ToString() + " segundos.");
        }
    }
}
