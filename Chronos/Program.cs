using System;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            var cronometro1 = new System.Diagnostics.Stopwatch();
            var cronometro2 = new System.Diagnostics.Stopwatch();

            cronometro1.Start();

            Thread.Sleep(600);

            cronometro2.Start();

            Thread.Sleep(200);

            cronometro1.Stop();
            cronometro2.Stop();

            Console.WriteLine("Tempo decorrido em crononometro 1: {0:F3} segundos", crono1.Elapsed.TotalSeconds);
            Console.WriteLine("Tempo decorrido em cronometro 2: {0:F3} segundos", crono2.Elapsed.TotalSeconds);
        }
    }
}
