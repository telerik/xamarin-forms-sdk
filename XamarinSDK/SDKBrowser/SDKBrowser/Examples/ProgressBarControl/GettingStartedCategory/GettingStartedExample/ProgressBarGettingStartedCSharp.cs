using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ProgressBarControl.GettingStartedCategory.GettingStartedExample
{
    public class ProgressBarGettingStartedCSharp : ContentView
    {
        public ProgressBarGettingStartedCSharp()
        {
            // >> progressbar-getting-started-csharp
            var progressBarr = new RadLinearProgressBar()
            {
                Value = 25
            };
            // <<  progressbar-getting-started-csharp

            var stack = new StackLayout();
            stack.Children.Add(progressBarr);
            Content = stack;
        }
    }
}