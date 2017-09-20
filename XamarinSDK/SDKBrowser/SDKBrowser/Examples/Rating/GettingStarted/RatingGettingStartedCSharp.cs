using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Rating
{
    public class RatingGettingStartedCSharp : ContentPage
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