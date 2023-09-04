using System.Collections;
using System.Runtime.InteropServices;

namespace ToDoList;

class Program
{
    public static void Main(string[] args)
    {
        List<string> tasks = new List<string>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Ver tarefas");
            Console.WriteLine("3 - Remover uma tarefa");
            Console.WriteLine("4 - Sair");

            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddTask(tasks);
                    break;
                case 2:
                    ViewTasks(tasks);
                    break;
                case 3:
                    DeleteTask(tasks);
                    break;
                case 4:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
                    
            }

            static void AddTask(List<string> tasks)
                {
                    Console.WriteLine("Digite sua tarefa");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                }

            static void ViewTasks(List<string> tasks)
            {
                Console.WriteLine("Lista de tarefas: ");
                foreach (string task in tasks)
                    {
                        Console.WriteLine(task);
                    }
            }

            static void DeleteTask(List<string> tasks)
            {
                Console.WriteLine("Digite a tarefa que deseja Excluir: ");
                string task = Console.ReadLine();

                bool isRemoved = tasks.Remove(task);

                if (!isRemoved)
                {
                    Console.WriteLine("Tarefa não encontrada!");
                }
            }

        }
    }
}