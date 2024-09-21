using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            Task task = new Task();
            while (true)
            {
                Console.WriteLine("Виберіть дію:\n1. Додати завдання\n2. Видалити завдання\n3. Показати список завдань\n4. Позначити виконаним\n5. Вийти"); 
                char action = char.Parse(Console.ReadLine());
                switch (action)
                {
                    case '1':
                        task.AddTask(tasks);
                        break;
                    case '2':
                        task.RemoveTask(tasks);
                        break;
                    case '3':
                        task.ShowTaskList(tasks);
                        break;
                    case '4':
                        task.MarkCompleted(tasks);
                        break;
                    case '5':
                        return;
                    default:
                        Console.WriteLine("\nВи ввели неправильний номер завдання");
                        break;
                }
            }
        }
    }  
}
