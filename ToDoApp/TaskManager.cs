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
            IdCounter = Math.Max(IdCounter, Tasks[Tasks.Count-1].Id + 1);
        }
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
    }
}
