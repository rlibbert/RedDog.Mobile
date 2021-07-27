using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TestMobileApp.Models;
using Xamarin.Forms;
using System.Windows.Input;
using Xamarin.Essentials;
using Flurl.Http;

namespace TestMobileApp.ViewModels
{

    [QueryProperty(nameof(ItemId), nameof(ItemId))]


    public class ItemDetailViewModel : BaseViewModel

    {


        private string itemId;
        private string text;
        private string description;
        private string unitprice;


        public string Id { get; set; }

        public string UnitPrice
        {
            get => unitprice;
            set => SetProperty(ref unitprice, value);
        }
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                UnitPrice = item.UnitPrice;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        //Order Code



        public Command PlaceOrderCommand { get; }

        public ItemDetailViewModel()
        {
            PlaceOrderCommand = new Command(OrderItem);
        }


        private async void OrderItem(object obj)
        {

            await "http://denver.order.brianredmond.io/order"
                .PostJsonAsync(new
                {
                    storeId = "Redmond",
                    firstName = "Mobile",
                    lastName = "App",
                    loyaltyId = "42",
                    orderItems = new[] {new
                    {
                         productId = "3",
                        quantity = "1"
                    } }
                });

            await Shell.Current.GoToAsync($"//{nameof(Views.AboutPage)}");
        }


        //DoneOrderCode
     


    }

}
