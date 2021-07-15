using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList_XF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoList_XF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoListPage : ContentPage
    {
        public TodoListPage()
        {
            InitializeComponent();

            BindingContext = new TodoListViewModel();
        }

        private async void NewTodo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddTodoPage());
        }
    }
}