using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.PopupControl.FeaturesCategory.PopupPlacementExample
{
    public class PopupPlacementCSharp : ContentView
    {
        public PopupPlacementCSharp()
        {
            // >> popup-features-placement-code
            var myButton = new Button()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                BackgroundColor = Color.FromHex("#7A9BFF"),
                TextColor = Color.White,
                Text = "Show popup",
            };

            var popup = new RadPopup()
            {
                Placement = PlacementMode.Bottom,
                HorizontalOffset = 20,
                VerticalOffset = 20,
                PlacementTarget = myButton
            };

            myButton.Clicked += ((sender, args) => { popup.IsOpen = true; });

            popup.Content = new RadBorder()
            {
                WidthRequest = 180,
                CornerRadius = new Thickness(6),
                BackgroundColor = Color.FromHex("#93D7FF"),
                BorderColor = Color.FromHex("#7A9BFF"),
                Padding = new Thickness(10),
                Content = new Label() { Text= "With Telerik Popup for Xamarin you could easily add modal popups to your application in order to draw attention to important information or receive user input."}
            };         

            this.Content = new Grid()
            {
                Margin = new Thickness(10),
                Children = { myButton  }
            };
            // << popup-features-placement-code
        }
    }
}