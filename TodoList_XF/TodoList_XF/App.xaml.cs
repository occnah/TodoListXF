using System;
using System.Collections.ObjectModel;
using TodoList_XF.Models;
using TodoList_XF.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoList_XF
{
    public partial class App : Application
    {
        public static ObservableCollection<Todo> TodoList { get; set; } = new ObservableCollection<Todo>
        {
            new Todo("Walk the dog", DateTime.Today, false),
            new Todo("Buy milk", DateTime.Today, false),
            new Todo("Rig an election", DateTime.Today, true),
            new Todo("Hack the government", DateTime.Today, true),
            new Todo("Do the dishes", DateTime.Today, false),
        };

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
