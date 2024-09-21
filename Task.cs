namespace Program;

public class Task
{
    public string Name { get; set; }
    public bool Completed { get; set; }
    public string Description { get; set; }

    public void AddTask(List<Task> tasks)
    {
        Console.Write("Введіть назву завдання: ");
        string name = Console.ReadLine();
        Console.Write("Введіть опис завдання: ");
        string description = Console.ReadLine();
        tasks.Add(new Task { Name = name, Description = description, Completed = false });
    }

    public void RemoveTask(List<Task> tasks)
    {
        if (!HasTasks(tasks)) return;

        Console.Write("Введіть номер завдання, яке ви хочете видалити: ");
        if (TryGetTaskNumber(out int numTask, tasks.Count))
        {
            tasks.RemoveAt(numTask - 1);
        }
    }

    public void ShowTaskList(List<Task> tasks)
    {
        if (!HasTasks(tasks)) return;

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
        if (!HasTasks(tasks)) return;

        Console.Write("Введіть номер завдання, щоб позначити його як виконане: ");
        if (TryGetTaskNumber(out int taskNum, tasks.Count))
        {
            tasks[taskNum - 1].Completed = true;
            Console.WriteLine("Завдання позначено як виконане.");
        }
    }

    private bool HasTasks(List<Task> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Завдань не знайдено.");
            return false;
        }
        return true;
    }

    private bool TryGetTaskNumber(out int taskNum, int max)
    {
        if (int.TryParse(Console.ReadLine(), out taskNum) && taskNum > 0 && taskNum <= max)
            return true;

        Console.WriteLine("Невірний номер завдання.");
        taskNum = -1;
        return false;
    }
}