using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class TaskManager
    {
        public List<TodoTask> Tasks = new List<TodoTask>();
        public int IdCounter = 1;

        public TaskManager() 
        {
            Tasks = FileManager.ReadFromFile("tasks.txt");
            if (Tasks.Count > 0)
            {
                IdCounter = Math.Max(IdCounter, Tasks[Tasks.Count - 1].Id + 1);
            }
        }
        public void AddTask(string Title)
        {
            Tasks.Add(new TodoTask(IdCounter, Title));
            IdCounter++;
        }
        public void DeleteTask(int Id)
        {
            Tasks.RemoveAll(t => t.Id == Id);
        }

        public void CompleteTask(int Id)
        {
            TodoTask task = Tasks.Find(t => t.Id == Id);
            if (task != null)
            {
                if (task.IsCompleted == false)
                {
                    task.IsCompleted = true;
                    Console.WriteLine("Uppgiften är nu markerad som klar!");
                    return;
                }
                if (task.IsCompleted == true)
                {
                    task.IsCompleted = false;
                    Console.WriteLine("Uppgiften är nu markerad som inte klar!");
                    return;
                }
            }

            if (Tasks.Count() == 0)
            {
                Console.WriteLine("Inga uppgifter att markera som klara.");
                return;
            }

            else
            {
                Console.WriteLine("Uppgift inte hittad!");
            }
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
