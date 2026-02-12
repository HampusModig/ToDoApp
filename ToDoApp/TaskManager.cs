using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class TaskManager
    {
        public List<TodoTask> Tasks = new List<TodoTask>();
        public int IdCounter = 0;

        public TaskManager() 
        {
            ReadFromFile("tasks.txt");
        }
        public void AddTask(string Title)
        {
            Tasks.Add(new TodoTask(IdCounter, Title));
            IdCounter++;
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
                }
                if (task.IsCompleted == true)
                {
                    task.IsCompleted = false;
                    Console.WriteLine("Uppgiften är nu markerad som inte klar!");
                }
            }

            if (Tasks.Count() == 0)
            {
                Console.WriteLine("Inga uppgifter att markera som klara.");
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
        public string ListToString() 
        {
            StringBuilder sb = new StringBuilder();
            foreach (TodoTask t in Tasks)
            {
                sb.AppendLine($"{t.Id};{t.Title};{(t.IsCompleted ? "True" : "False")}");
            }
            return sb.ToString();
        }

        public void WriteToFile(string filePath)
        {
            System.IO.File.WriteAllText(filePath, ListToString());
        }

        public void ReadFromFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        int id = int.Parse(parts[0]);
                        string title = parts[1];
                        bool isCompleted = bool.Parse(parts[2]);
                        Tasks.Add(new TodoTask(id, title, isCompleted));
                        IdCounter = Math.Max(IdCounter, id + 1);
                    }
                }
            }
        }
    }
}
