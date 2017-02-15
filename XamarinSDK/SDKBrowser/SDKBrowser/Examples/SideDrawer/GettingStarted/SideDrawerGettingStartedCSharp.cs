using Xamarin.Forms;
using Telerik.XamarinForms.Primitives;

namespace SDKBrowser.Examples.SideDrawer
{
    public class SideDrawerGettingStartedCSharp : ContentPage
    {
        public SideDrawerGettingStartedCSharp()
        {
            // >> sidedrawer-gettingstarted-csharp
            var drawerContent = new StackLayout();
            drawerContent.Children.Add(new Button { Text = "Mail" });
            drawerContent.Children.Add(new Button { Text = "Calendar" });
            drawerContent.Children.Add(new Button { Text = "People" });
            drawerContent.Children.Add(new Button { Text = "Tasks" });

            var sideDrawer = new RadSideDrawer
            {
                MainContent = new Label { Text = "Main content" },
                DrawerContent = drawerContent,
                DrawerLength = 200
            };
            // << sidedrawer-gettingstarted-csharp

            Content = sideDrawer;
        }
    }
}

