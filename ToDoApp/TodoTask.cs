using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    internal class TodoTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public TodoTask(int id, string title)
        {
            Id = id;
            Title = title;
            IsCompleted = false;
        }
    }
}
