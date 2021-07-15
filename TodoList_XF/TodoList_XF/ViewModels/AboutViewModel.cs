using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TodoList_XF.ViewModels
{
    class AboutViewModel
    {
        public Command VisitWebCommand => new Command(VisitWeb);

        public async void VisitWeb()
        {
            await Browser.OpenAsync("https://github.com/occnah");
        }
    }
}
