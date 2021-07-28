using System;
using System.Collections.Generic;
using System.Text;
using TestMobileApp.Views;
using Xamarin.Forms;

namespace TestMobileApp.ViewModels
{
    public class OrderCompleteModel : BaseViewModel
    {
        public Command ReturnComplete { get; }

        public OrderCompleteModel()
        {
            ReturnComplete = new Command(OrderCompleteClicked);
        }

        private async void OrderCompleteClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
