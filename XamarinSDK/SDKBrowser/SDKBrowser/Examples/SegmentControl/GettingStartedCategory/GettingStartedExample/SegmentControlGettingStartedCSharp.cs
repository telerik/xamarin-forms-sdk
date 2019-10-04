using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SegmentControl.GettingStartedCategory.GettingStartedExample
{
    public class SegmentControlGettingStartedCSharp : ContentView
    {
        public SegmentControlGettingStartedCSharp()
        {
            var mainGrid = new Grid();
            // >> segmentcontrol-gettingstarted-csharp
            RadSegmentedControl segmentControlText = new RadSegmentedControl()
            {
                VerticalOptions = LayoutOptions.Start, HeightRequest = 60,
                ItemsSource = new List<string>() { "Popular", "Library", "Playlists", "Friends" },
            };
            // << segmentcontrol-gettingstarted-csharp
            mainGrid.Children.Add(segmentControlText);

            // >> segmentcontrol-gettingstarted-images-csharp
            RadSegmentedControl segmentControlImages = new RadSegmentedControl()
            {
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = 60,
                ItemsSource = new List<FileImageSource>() { "available.png", "away.png", "busy.png" },
            };
            // << segmentcontrol-gettingstarted-images-csharp
            mainGrid.Children.Add(segmentControlImages, 0, 1);
           
            this.Content = mainGrid;
        }
    }
}
