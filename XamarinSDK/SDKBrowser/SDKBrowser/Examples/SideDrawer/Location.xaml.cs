using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Primitives;
using Telerik.XamarinForms.Primitives.SideDrawer;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SideDrawer
{
	public partial class Location : ContentPage
	{
        public Location()
		{
			InitializeComponent();

            this.drawerList.ItemsSource = new List<string>() { "Inbox", "Drafts", "Sent Items" };
            var list = Enum.GetValues(typeof(SideDrawerLocation)).OfType<SideDrawerLocation>().ToList();
            this.listview.ItemsSource = list;
            Device.BeginInvokeOnMainThread(() => this.listview.SelectedItem = list[2]);
           
            this.listview.ItemSelected += listview_ItemSelected;
		}

        void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                drawer.DrawerLocation = (SideDrawerLocation)e.SelectedItem;
            }
        }

        void OnToolbarButtonClick(object sender, EventArgs e)
        {
            drawer.IsOpen = !drawer.IsOpen;
        }
	}
}