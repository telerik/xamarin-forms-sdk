using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ExpanderControl.GettingStartedCategory.GettingStartedExample
{
    public class ExpanderGettingStartedCSharp : ContentView
    {
        public ExpanderGettingStartedCSharp()
        {
            // >> expander-gettingstarted-csharp
            var expander = new RadExpander { HeaderText = "More Options" };

            var stackContainer = new StackLayout { Margin = new Thickness(10, 20, 10, 20) };
            var firstCheckboxStack = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = new Thickness(10) };
            firstCheckboxStack.Children.Add(new RadCheckBox());
            firstCheckboxStack.Children.Add(new Label { Text = "Make my profile private" });
            stackContainer.Children.Add(firstCheckboxStack);

            var secondCheckboxStack = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = new Thickness(10, 20, 10, 20) };
            secondCheckboxStack.Children.Add(new RadCheckBox());
            secondCheckboxStack.Children.Add(new Label { Text = "Only show my posts to people who follow me" });
            stackContainer.Children.Add(secondCheckboxStack);

            expander.Content = stackContainer;
            // << expander-gettingstarted-csharp
            Content = expander;
        }
    }
}
