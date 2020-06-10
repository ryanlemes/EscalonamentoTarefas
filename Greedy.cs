using System;
using System.Collections.Generic;

namespace EscalonamentoTarefas
{
    static class Greedy
    {
        public static List<Task> greedy(List<Task> T, int max)
        {
            List<Task> solucao = new List<Task>();
            int somaSolucao = 0;

            for (int IndiceMenor = 0; IndiceMenor < T.Count; IndiceMenor++)
            {
                int Menor = Int32.MaxValue;
                for (int k = IndiceMenor; k < T.Count; k++)
                {
                    if (T[k].time < Menor)
                    {
                        Menor = T[k].time;
                        IndiceMenor = k;
                    }
                }

                if (Menor < max && (somaSolucao + T[IndiceMenor].time) <= max)
                {
                    solucao.Add(T[IndiceMenor]);
                    somaSolucao += T[IndiceMenor].time;
                }
            }

            return solucao;
        }
    }
}
