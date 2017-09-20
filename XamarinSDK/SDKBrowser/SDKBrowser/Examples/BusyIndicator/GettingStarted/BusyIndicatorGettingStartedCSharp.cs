using Xamarin.Forms;
using Telerik.XamarinForms.Primitives;

namespace SDKBrowser.Examples.BusyIndicator
{
    public class BusyIndicatorGettingStartedCSharp : ContentPage
    {
        public BusyIndicatorGettingStartedCSharp()
        {
            // >> busyindicator-getting-started-csharp
            RadBusyIndicator radBusyIndicator = new RadBusyIndicator()
            {
                IsBusy = true,                
                Content = new Label() { Text = "This is the content of the RadBusyIndicator control displayed when the indicator is not busy.", TextColor = Color.Black },
                AnimationContentWidthRequest = 100,
                AnimationContentHeightRequest = 100,
            };
            // << busyindicator-getting-started-csharp

            this.BackgroundColor = Color.White;
            this.Content = radBusyIndicator;
        }
    }
}

