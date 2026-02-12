using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public static class FileManager
    {
        public static string ListToString(List<TodoTask> Tasks)
        {
            StringBuilder sb = new StringBuilder();
            foreach (TodoTask t in Tasks)
            {
                sb.AppendLine($"{t.Id};{t.Title};{(t.IsCompleted ? "True" : "False")}");
            }
            return sb.ToString();
        }

        public static void WriteToFile(string filePath, List<TodoTask> Tasks)
        {
            System.IO.File.WriteAllText(filePath, ListToString(Tasks));
        }

        public static List<TodoTask> ReadFromFile(string filePath)
        {
            List<TodoTask> Tasks = new List<TodoTask>();
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
                    }
                }
            }
            return Tasks;
        }
    }
}
