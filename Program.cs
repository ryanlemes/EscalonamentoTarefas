using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EscalonamentoTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int W = 5;

            List<Task> tarefas = Data.PopulateRandom(90);

            #region BrutalForce
            Console.WriteLine("-------------------Algoritmo Forca Bruta-------------------");

            stopwatch.Start();
            List<Task> listasolucaoForcaBruta = new List<Task>();
            while (stopwatch.Elapsed.Seconds != 5)
            {
                listasolucaoForcaBruta = BruteForce.bruteForce(tarefas, W, 0);
                Data.PopulateRandom(90).CopyTo(tarefas.ToArray());
            }

            Data.PrintData(listasolucaoForcaBruta);
            stopwatch.Stop();

            TimeSpan time = stopwatch.Elapsed;
            Console.WriteLine($"Tempo do processo processo: {time.Milliseconds} ms");
            #endregion

            #region Guloso
            Console.WriteLine("---------------------Algoritmo Guloso---------------------");

            stopwatch.Restart();
            tarefas = Data.PopulateRandom(90);
            List<Task> listaSolucaoGulosa = new List<Task>();

            while (stopwatch.Elapsed.Seconds != 5)
            {
                listaSolucaoGulosa = Greedy.greedy(tarefas, W);
                Data.PopulateRandom(90).CopyTo(tarefas.ToArray());
            }

            Data.PrintData(listaSolucaoGulosa);
            stopwatch.Stop();

            time = stopwatch.Elapsed;
            Console.WriteLine($"Tempo do processo processo: {time.Milliseconds} ms");
            #endregion

            #region Dinamico
            Console.WriteLine("---------------------Algoritmo Dinamico--------------------");

            stopwatch.Restart();
            tarefas = Data.PopulateRandom(90);

            List<Task> listaSolucaoDinamica = new List<Task>();
            while (stopwatch.Elapsed.Seconds != 5)
            {
                var a = Dynamic.dynamic(tarefas.Count - 1, W, W, tarefas, ref listaSolucaoDinamica);
                Data.PopulateRandom(90).CopyTo(tarefas.ToArray());
            }

            Data.PrintData(listaSolucaoDinamica);
            stopwatch.Stop();

            time = stopwatch.Elapsed;
            Console.WriteLine($"Tempo do processo processo: {time.Milliseconds} ms");
            #endregion

            Console.ReadKey();
        }
    }
}
