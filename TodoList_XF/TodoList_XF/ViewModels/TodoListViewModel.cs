using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TodoList_XF.Models;
using Xamarin.Forms;

namespace TodoList_XF.ViewModels
{
    class TodoListViewModel
    {
        public ObservableCollection<Todo> Todos { get; set; }

        public string TodoText { get; set; }

        public DateTime DueDate { get; set; }

        public TodoListViewModel()
        {
            Todos = App.TodoList;
        }

        public Command AddTodoCommand => new Command(AddTodo);
        public Command DeleteTodoCommand => new Command(DeleteTodo);

        public void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(TodoText))
            {
                Todos.Add(new Todo(TodoText, DueDate, false));

                App.TodoList = Todos;
            }
        }

        public void DeleteTodo(object o)
        {
            Todo todoToDelete = o as Todo;
            Todos.Remove(todoToDelete);

            App.TodoList = Todos;
        }
    }
}