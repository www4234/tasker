using System;
using System.Collections.Generic;

class TaskItem
{
    public string taskName { get; set; }
    public bool isDone { get; set; }
    
    public override string ToString()
    {
        if (isDone)
        {
            return "[X] " + taskName;
        }
        else
        {
            return "[] " + taskName;
        }
    }
}

class Program
{
    static void Main()
    {
        List<TaskItem> tasks = new List<TaskItem>();
        
        tasks.Add(new TaskItem { taskName = "Купить молоко", isDone = false });
        tasks.Add(new TaskItem { taskName = "Сделать домашнее задание", isDone = true });
        tasks.Add(new TaskItem { taskName = "Позвонить другу", isDone = false});
        
        // Выводим список с номерами для удобства пользователя (с 1)
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }

        Console.Write("\nКакую задачу вы хотите отметить? (напишите 0 чтобы выйти): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice != 0)
        {
            // Переводим пользовательский номер в индекс списка (вычитаем 1)
            int index = choice - 1;

            // Проверяем, существует ли задача с таким номером
            if (index >= 0 && index < tasks.Count)
            {
                // Инвертируем статус: если было false — станет true, и наоборот
                tasks[index].isDone = !tasks[index].isDone;

                Console.WriteLine("\nСтатус задачи изменен! Обновленный список:");
                foreach (var task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
            else
            {
                Console.WriteLine("Задачи с таким номером не существует.");
            }
        }
        else
        {
            Environment.Exit(0);
        }
    }
}
