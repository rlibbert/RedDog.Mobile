using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderComplete : ContentPage
    {
        public OrderComplete()
        {
            InitializeComponent();
            this.BindingContext = new OrderComplete();
        }
    }
}