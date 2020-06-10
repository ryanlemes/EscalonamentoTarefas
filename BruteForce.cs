using System.Collections.Generic;

namespace EscalonamentoTarefas
{
    static class BruteForce
    {
        public static List<Task> bruteForce(List<Task> T, int Max, int somaSolucoes)
        {
            List<Task> solucao = new List<Task>();
            List<List<Task>> solucoes = new List<List<Task>>();

            for (int i = 0; i < T.Count; i++)
            {
                solucoes.Add(recursive(T, Max, 0));
            }

            int maxValor = solucoes[0].Count;

            foreach (List<Task> list in solucoes)
            {
                if (list.Count >= maxValor)
                {
                    solucao = list;
                }
            }

            return solucao;
        }

        private static List<Task> recursive(List<Task> T, int Max, int SomaSolucoes)
        {
            List<Task> tarefas = new List<Task>();

            for (int i = 0; i < T.Count; i++)
            {
                if (SomaSolucoes + T[i].time <= Max)
                {
                    tarefas.Add(T[i]);
                }
            }

            return tarefas;
        }
    }
}
