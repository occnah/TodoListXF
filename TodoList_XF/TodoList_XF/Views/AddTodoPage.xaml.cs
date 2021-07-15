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
    public partial class AddTodoPage : ContentPage
    {
        public AddTodoPage()
        {
            InitializeComponent();

            BindingContext = new TodoListViewModel();
        }

        private async void PopModal(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}