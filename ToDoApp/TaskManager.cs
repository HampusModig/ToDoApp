using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        public void EditTask(int Id, string newTitle)
        {
            var task = Tasks.Find(t => t.Id == Id);
            bool run = true;
            while (run)
            {     
                if (string.IsNullOrWhiteSpace(newTitle))
                {
                    Console.WriteLine("Titeln får inte vara tom. Ange en giltig titel:");
                    newTitle = Console.ReadLine();
                }
                else if(task != null)
                    {

                    task.Title = newTitle;
                    Console.WriteLine("Uppgift uppdaterad.");
                    run = false;
                }
                else
                {
                    Console.WriteLine("Uppgift inte hittad.");
                    run = false;
                }
                
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
