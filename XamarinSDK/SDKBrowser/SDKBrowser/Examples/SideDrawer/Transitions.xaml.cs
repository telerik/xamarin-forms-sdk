using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SideDrawer
{
	public partial class Transitions : ContentPage
	{
		public Transitions()
		{
			InitializeComponent();
			picker.SelectedIndex = 0;

            this.drawerList.ItemsSource = new List<string>() { "Inbox", "Drafts", "Sent Items" };

            if (Device.OS == TargetPlatform.Windows)
            {
                 descritpionLabel.Text = "Right click or swipe from bottom to access toolbar. Alternatively you can swipe from left to open the sidedrawer directly.";
            }
		}

        void OnToolbarButtonClick(object sender, EventArgs e)
        {
            drawer.IsOpen = !drawer.IsOpen;
        }

		void picker_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch ((sender as Picker).SelectedIndex)
			{
                case 1: drawer.DrawerTransitionType = SideDrawerTransitionType.Reveal; break;
				case 2: drawer.DrawerTransitionType = SideDrawerTransitionType.ReverseSlideOut; break;
				case 3: drawer.DrawerTransitionType = SideDrawerTransitionType.ScaleUp; break;
				case 4: drawer.DrawerTransitionType = SideDrawerTransitionType.SlideAlong; break;
				case 5: drawer.DrawerTransitionType = SideDrawerTransitionType.SlideInOnTop; break;
                default: drawer.DrawerTransitionType = SideDrawerTransitionType.Push; break;
			}
		}
	}
}