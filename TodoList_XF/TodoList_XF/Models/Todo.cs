using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList_XF.Models
{
    public class Todo
    {
        public string TodoText { get; set; }

        // Type set to string so it can be formatted correctly when displayed
        public string DueDate { get; set; }

        public bool IsCompleted { get; set; }

        public Todo(string todoText, DateTime dueDate, bool isCompleted)
        {
            TodoText = todoText;
            DueDate = dueDate.ToString("MM/dd/yy");
            IsCompleted = isCompleted;
        }
    }
}
