using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinStarter
{
    public partial class MenuPage : ContentPage
    {
        public ListView MenuListView { get { return listMenu; } }

        public MenuPage()
        {
            InitializeComponent();
            
            listMenu.ItemsSource = new List<HamburgerMenuItem>() {
                new HamburgerMenuItem() { Title = "Home Page", IconSource = Device.OnPlatform(ImageSource.FromFile("star.png"), ImageSource.FromFile("star.png"), ImageSource.FromFile("Resources/star.png")), TargetType=typeof(MainPage) },
                new HamburgerMenuItem() { Title = "Items List", IconSource = Device.OnPlatform(ImageSource.FromFile("star.png"), ImageSource.FromFile("star.png"), ImageSource.FromFile("Resources/star.png")), TargetType=typeof(ItemsList) }
            };
        }

        /*
        void OnMenuItemSelection(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as HamburgerMenuItem;

            if (item != null)
            {
                var listPage = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                var homePage = App.NavigationPage.Navigation.NavigationStack.First();
                App.NavigationPage.Navigation.InsertPageBefore(listPage, homePage);
                App.NavigationPage.Navigation.PopToRootAsync(false);

                //TODO: Hide menu after click.
            }
        }
        */
    }

    public class HamburgerMenuItem
    {
        public string Title { get; set; }
        public Xamarin.Forms.ImageSource IconSource { get; set; }
        public Type TargetType { get; set; }
    }
}