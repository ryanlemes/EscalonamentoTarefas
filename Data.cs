using System;
using System.Collections.Generic;
using System.Linq;

namespace EscalonamentoTarefas
{
    public static class Data
    {
        public static List<Task> PopulateRandom(int value)
        {
            List<Task> tarefas = new List<Task>();

            Random r = new Random();

            for (int i = 0; i < value; i++)
            {
                tarefas.Add(new Task()
                {
                    time = (int)(r.NextDouble() * 6),
                    id = i,
                });

            }

            tarefas = tarefas.OrderBy(i => i.time).ToList();

            return tarefas;
        }

        public static List<Task> Mock()
        {
            List<Task> tarefas = new List<Task>
            {
                new Task()
                {
                    time = 9,
                    id = 1,
                },

                new Task()
                {
                    time = 15,
                    id = 2,
                },

                new Task()
                {
                    time = 3,
                    id = 3,
                },
                new Task()
                {
                    time = 8,
                    id = 4,
                },
                new Task()
                {
                    time = 5,
                    id = 5,
                }
            };

            tarefas = tarefas.OrderBy(i => i.time).ToList();

            return tarefas;
        }

        public static void PrintData(List<Task> t)
        {
            foreach (Task tarefa in t)
            {
                Console.WriteLine($"Id: {tarefa.id} | Tempo: {tarefa.time}");
            }
        }
    }
}
