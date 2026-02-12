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
    }
}
