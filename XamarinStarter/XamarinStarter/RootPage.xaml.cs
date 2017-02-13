using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinStarter
{
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
            
            menuPage.MenuListView.ItemSelected += MenuListView_ItemSelected;
        }

        private void MenuListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as HamburgerMenuItem;

            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                menuPage.MenuListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}