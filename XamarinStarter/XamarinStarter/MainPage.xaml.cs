using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinStarter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            /*
            Services.AttributeManager am = new Services.AttributeManager();
            bool result = await am.GetAttributeCount();

            if (result)
            {
                await DisplayAlert("Service Status", "Connnected with the APIs!", "OK");
            }
            else
            {
                await DisplayAlert("Service Status", "Can't connnect with the APIs!", "OK");
            }
            */
        }

        async void OnSignInButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsList());
        }
    }
}
