using Telerik.XamarinForms.Common;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DockLayoutControl.GettingStartedCategory.GettingStartedExample
{
    public class DockLayoutGettingStartedCSharp : ContentView
    {
        public DockLayoutGettingStartedCSharp ()
        {
            // >> docklayout-getting-started-csharp
            var dockLayout = new RadDockLayout();

            var topGrid = new Grid { HeightRequest = 60, BackgroundColor = Color.FromHex("009688")};
            topGrid.Children.Add(new Label { Margin = 20, Text = "Title" });
            topGrid.SetValue(RadDockLayout.DockProperty, Dock.Top);
            dockLayout.Children.Add(topGrid);

            var leftGrid = new Grid { HeightRequest = 60, BackgroundColor = Color.FromHex("659BFC")};
            leftGrid.Children.Add(new Label { Margin = 20, Text = "Navigation" });
            leftGrid.SetValue(RadDockLayout.DockProperty, Dock.Left);
            dockLayout.Children.Add(leftGrid);

            var bottomGrid = new Grid { WidthRequest = 120, BackgroundColor = Color.FromHex("1455C9")};
            bottomGrid.Children.Add(new Label { Margin = 20, Text = "Bottom" });
            bottomGrid.SetValue(RadDockLayout.DockProperty, Dock.Bottom);
            dockLayout.Children.Add(bottomGrid);

            var lastGrid = new Grid { HeightRequest = 60, BackgroundColor = Color.FromHex("FCCFB0")};
            lastGrid.Children.Add(new Label { Margin = 20, Text = "Content" });
            dockLayout.Children.Add(lastGrid);
            // << docklayout-getting-started-csharp
            this.Content = dockLayout;
        }
    }
}