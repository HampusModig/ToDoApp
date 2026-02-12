using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    internal class TaskManager
    {
        public List<TodoTask> Tasks = new List<TodoTask>();
        public int IdCounter = 0;

        public void AddTask(string Title)
        {
            Tasks.Add(new TodoTask(IdCounter, Title));
            IdCounter++;
        }

        public void DisplayAllTasks()
        {
            foreach (TodoTask t in Tasks)
            {
                Console.WriteLine($"ID: {t.Id} | Titel: {t.Title} | Klar: {(t.IsCompleted ? "Ja" : "Nej")}");
            }
        }

        public void DisplayTaskByStatus(bool IsCompleted)
        {
            var filteredTasks = Tasks.FindAll(t => t.IsCompleted == IsCompleted).ToList();

            if (filteredTasks.Count == 0)
            {
                Console.WriteLine("Inga uppgifter att visa.");
                return;
            }
            else
            {
                foreach(var task in filteredTasks)
                {
                    Console.WriteLine($"ID: {task.Id} | Titel: {task.Title} | Klar: {(task.IsCompleted ? "Ja" : "Nej")}");
                }
            }
        }
    }
}
