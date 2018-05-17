using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.RatingControl.GettingStartedCategory.GettingStartedExample
{
    public class RatingGettingStartedCSharp : ContentView
    {
        public RatingGettingStartedCSharp()
        {
            // >> rating-gettingstarted-csharp
            var layout = new StackLayout();
            layout.Children.Add(new RadShapeRating());
            this.Content = layout;
            // << rating-gettingstarted-csharp
        }
    }
}