using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CheckBoxControl.GettingStartedCategory.GettingStartedExample
{
    public class CheckBoxGettingStartedCSharp : ContentView
    {
        public CheckBoxGettingStartedCSharp()
        {
            // >> checkbox-getting-started-csharp
            var mainLayout = new StackLayout() { Orientation = StackOrientation.Horizontal };
            mainLayout.Children.Add(new RadCheckBox());            
            mainLayout.Children.Add(new Label() { Text = "Agree to the Terms & Conditions"});
            // << checkbox-getting-started-csharp
            this.Content = mainLayout;
        }

        
    }
}
