using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTarefas
{
    internal class Todo
    {
        private readonly List<string> _tarefas = new();

        public void AdicionarTarefa()
        {
            Console.WriteLine("Digite a tarefa a ser adicionada: ");
            string tarefa = Console.ReadLine();
            if (tarefa != null)
            {
                _tarefas.Add(tarefa);
            }
            else
            {
                Console.WriteLine("Digite uma tarefa válida. ");
            }
        }

        public void RemoverTarefa()
        {
            Console.WriteLine("Digite a tarefa que deseja remover: ");
            string tarefa = Console.ReadLine() ?? string.Empty;
            _tarefas.Remove(tarefa);
        }
        
        public void AtualizarTarefa()
        {
            Console.WriteLine("Digite o índice da tarefa que deseja atualizar: ");
            var index = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nova tarefa: ");
            var tarefa = Console.ReadLine();

            _tarefas[index] = tarefa;
        }

        public void ListarTodasTarefas()
        {
            for(int i = 0; i < _tarefas.Count; i++)
            {
                Console.WriteLine($"{_tarefas[i]};");
            }
        }

        public void ApresentarTarefaIndice()
        {
            Console.WriteLine("Digite o índice em que deseja apresentar a tarefa:");
            int indice = int.Parse(Console.ReadLine());

            Console.WriteLine(_tarefas[indice]);           
        }
    }
}
