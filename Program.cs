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

            Dictionary<char, Action> actions = new Dictionary<char, Action>()
            {
                { '1', () => task.AddTask(tasks) },
                { '2', () => task.RemoveTask(tasks) },
                { '3', () => task.ShowTaskList(tasks) },
                { '4', () => task.MarkCompleted(tasks) },
                { '5', () => Environment.Exit(0) }
            };

            while (true)
            {
                try
                {
                    Console.WriteLine("Виберіть дію:\n1. Додати завдання\n2. Видалити завдання\n3. Показати список завдань\n4. Позначити виконаним\n5. Вийти");
                    char action = char.Parse(Console.ReadLine());

                    if (actions.ContainsKey(action))
                    {
                        actions[action].Invoke();
                    }
                    else
                    {
                        Console.WriteLine("\nВи ввели неправильний номер завдання");
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("\nВиникла помилка. Спробуйте ще раз.");
                }
            }
        }
    }
}