using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinStarter
{
    public partial class ItemsList : ContentPage
    {
        public ItemsList()
        {
            //Title = "Items List";

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //var listView = new ListView();
            //listView.ItemsSource = new string[]{
            //                      "mono",
            //                      "monodroid",
            //                      "monotouch",
            //                      "monorail",
            //                      "monodevelop",
            //                      "monotone",
            //                      "monopoly",
            //                      "monomodal",
            //                      "mononucleosis"
            //                    };


            List<Models.Attribute> attributes = new List<Models.Attribute>();

            attributes.Add(new Models.Attribute() { Image = Device.OnPlatform(ImageSource.FromFile("folder.png"), ImageSource.FromFile("folder.png"), ImageSource.FromFile("Resources/folder.png")), Name = "Item 1", Description = "Item 1 Description" });
            attributes.Add(new Models.Attribute() { Image = Device.OnPlatform(ImageSource.FromFile("folder.png"), ImageSource.FromFile("folder.png"), ImageSource.FromFile("Resources/folder.png")), Name = "Item 2", Description = "Item 2 Description" });
            attributes.Add(new Models.Attribute() { Image = Device.OnPlatform(ImageSource.FromFile("folder.png"), ImageSource.FromFile("folder.png"), ImageSource.FromFile("Resources/folder.png")), Name = "Item 3", Description = "Item 3 Description" });
            attributes.Add(new Models.Attribute() { Image = Device.OnPlatform(ImageSource.FromFile("folder.png"), ImageSource.FromFile("folder.png"), ImageSource.FromFile("Resources/folder.png")), Name = "Item 4", Description = "Item 4 Description" });
            attributes.Add(new Models.Attribute() { Image = Device.OnPlatform(ImageSource.FromFile("folder.png"), ImageSource.FromFile("folder.png"), ImageSource.FromFile("Resources/folder.png")), Name = "Item 5", Description = "Item 5 Description" });
            attributes.Add(new Models.Attribute() { Image = Device.OnPlatform(ImageSource.FromFile("folder.png"), ImageSource.FromFile("folder.png"), ImageSource.FromFile("Resources/folder.png")), Name = "Item 6", Description = "Item 6 Description" });
            attributes.Add(new Models.Attribute() { Image = Device.OnPlatform(ImageSource.FromFile("folder.png"), ImageSource.FromFile("folder.png"), ImageSource.FromFile("Resources/folder.png")), Name = "Item 7", Description = "Item 7 Description" });
            attributes.Add(new Models.Attribute() { Image = Device.OnPlatform(ImageSource.FromFile("folder.png"), ImageSource.FromFile("folder.png"), ImageSource.FromFile("Resources/folder.png")), Name = "Item 8", Description = "Item 8 Description" });
            attributes.Add(new Models.Attribute() { Image = Device.OnPlatform(ImageSource.FromFile("folder.png"), ImageSource.FromFile("folder.png"), ImageSource.FromFile("Resources/folder.png")), Name = "Item 9", Description = "Item 9 Description" });
            attributes.Add(new Models.Attribute() { Image = Device.OnPlatform(ImageSource.FromFile("folder.png"), ImageSource.FromFile("folder.png"), ImageSource.FromFile("Resources/folder.png")), Name = "Item 10", Description = "Item 10 Description" });

            listView.ItemsSource = attributes;

        }

        async void OnListViewItemSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            //DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");

            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.

            await Navigation.PushAsync(new ItemDetail());
        }

        public void OnListViewItemMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " MORE action", "OK");
        }

        public void OnListViewItemDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Context Action", mi.CommandParameter + " DELETE action", "OK");
        }
    }
}