using Xamarin.Forms;
using Telerik.XamarinForms.Primitives;

namespace SDKBrowser.Examples.SideDrawerControl.GettingStartedCategory.GettingStartedExample
{
    public class SideDrawerGettingStartedCSharp : ContentView
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

            Grid.SetRow(sideDrawer, 1);

            var hamburgerButton = new Button
            {
                WidthRequest = 32,
                HeightRequest = 32,
                BorderWidth = 0,
                CornerRadius = 0,
                BorderColor = Color.Transparent,
                BackgroundColor = Color.Transparent
            };

            if (Device.RuntimePlatform == Device.UWP)
            {
                hamburgerButton.ImageSource = (FileImageSource)
                    ImageSource.FromFile("Assets\\HamburgerMenu.png");
            }
            else
            {
                hamburgerButton.ImageSource = (FileImageSource)
                    ImageSource.FromFile("HamburgerMenu.png");
            }

            hamburgerButton.Clicked += (sender, args) =>
            {
                sideDrawer.IsOpen = !sideDrawer.IsOpen;
            };

            this.Content = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition
                    {
                        Height = GridLength.Auto
                    },
                    new RowDefinition()
                },
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Spacing = 10,
                        Children =
                        {
                            hamburgerButton,
                            new Label
                            {
                                VerticalOptions = LayoutOptions.Center,
                                Text = "SideDrawer"
                            }
                        }
                    },
                    sideDrawer
                }
            };
        }
    }
}
