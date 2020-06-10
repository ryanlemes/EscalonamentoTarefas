using System;
using System.Collections.Generic;
using System.Linq;

namespace EscalonamentoTarefas
{
    static class Dynamic
    {
        public static int dynamic(int linha, int coluna, int Max, List<Task> tarefas, ref List<Task> solucoes)
        {
            if (linha == 0 || coluna == 0)
            {
                return 0;
            };

            return Math.Min(coluna - dynamic(linha - 1, coluna, Max, tarefas, ref solucoes),
                            coluna - (dynamic(linha - 1, coluna - tarefas.ElementAt(linha - 1).time, Max, tarefas, ref solucoes) +
                            tarefas.ElementAt(linha - 1).time));
        }
    }
}
