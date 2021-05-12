using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.BadgeViewControl.GettingStartedCategory.GettingStartedExample
{
    public class BadgeViewGettingStartedCSharp : ContentView
    {
        public BadgeViewGettingStartedCSharp()
        {
            // >> badgeview-getting-started-csharp
            var badgeView = new RadBadgeView();
            badgeView.BadgeText = "1";
            badgeView.Content = new RadBorder
            {
                WidthRequest = 80,
                HeightRequest = 80,
                BorderThickness = 1,
                BorderColor = Color.LightGray,
                Content = new Label
                {
                    Text = "Telerik Badge View for Xamarin",
                    FontSize = 14,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                },
            };
            // << badgeview-getting-started-csharp

            var panel = new StackLayout();
            panel.HorizontalOptions = LayoutOptions.Center;
            panel.Children.Add(badgeView);
            this.Content = panel;
        }
    }
}