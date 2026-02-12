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

    }
}
