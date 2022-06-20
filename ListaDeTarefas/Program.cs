namespace ListaDeTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Todo todo = new Todo();

            todo.AdicionarTarefa();
            todo.AdicionarTarefa();
            todo.AdicionarTarefa();
            todo.ApresentarTarefaIndice();

            todo.RemoverTarefa();
            todo.AtualizarTarefa();
            todo.ListarTodasTarefas();
            todo.ApresentarTarefaIndice();
        }
    }
}