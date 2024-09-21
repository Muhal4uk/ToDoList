namespace Program;

public class Task
{
    public string Name { get; set; }
    public bool Completed { get; set; }
    public string Description { get; set; }

    public void AddTask(List<Task> tasks)
    {
        Console.WriteLine("Введіть назву завдання: ");
        string name = Console.ReadLine();
        Console.WriteLine("Введіть опис завдання: ");
        string description = Console.ReadLine();
        tasks.Add(new Task { Name = name, Description = description, Completed = false });
    }

    public void RemoveTask(List<Task> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Завдань для видалення немає.");
            return;
        }

        Console.WriteLine("Введіть номер завдання, яке ви хочете видалити:");
        int numTask = int.Parse(Console.ReadLine());
        if (numTask > 0 && numTask <= tasks.Count)
        {
            tasks.RemoveAt(numTask - 1);
        }
        else
        {
            Console.WriteLine("Невірний номер завдання.");
        }
    }

    public void ShowTaskList(List<Task> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Завдань не знайдено.");
            return;
        }

        Console.WriteLine("Список завдань:");
        for (int i = 0; i < tasks.Count; i++)
        {
            string status = tasks[i].Completed ? "Виконано" : "Не виконано";
            Console.WriteLine($"{i + 1}. {tasks[i].Name} - {tasks[i].Description} ({status})");
        }
    }

    public void MarkCompleted(List<Task> tasks)
    {
        ShowTaskList(tasks);
        if (tasks.Count == 0) return;

        Console.WriteLine("Введіть номер завдання, щоб позначити його як виконане:");
        if (int.TryParse(Console.ReadLine(), out int taskNum) && taskNum > 0 && taskNum <= tasks.Count)
        {
            tasks[taskNum - 1].Completed = true;
            Console.WriteLine("Завдання позначено як виконане.");
        }
        else
        {
            Console.WriteLine("Невірний номер завдання.");
        }
    }
}
