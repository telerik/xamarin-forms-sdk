using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SegmentControl
{
    public class SegmentControlGettingStartedCSharp : ContentPage
    {
        public SegmentControlGettingStartedCSharp()
        {
            // >> segmentcontrol-gettingstarted-csharp
            RadSegmentedControl segmentControl = new RadSegmentedControl()
            {
                VerticalOptions = LayoutOptions.Start, HeightRequest = 60,
                ItemsSource = new List<string>() { "Popular", "Library", "Playlists", "Friends" },                
            };
            // << segmentcontrol-gettingstarted-csharp

            this.Content = segmentControl;
        }
    }
}
