using Xamarin.Forms;
using Telerik.XamarinForms.Input;


namespace SDKBrowser.Examples.NumericInputControl.GettingStartedCategory.GettingStartedExample
{
    public class NumericInputGettingStartedCSharp : ContentView
    {
        public NumericInputGettingStartedCSharp()
        {
            // >> numericinput-getting-started-csharp
            var numericInput = new RadNumericInput();
            // << numericinput-getting-started-csharp
            var panel = new StackLayout();
            panel.Children.Add(numericInput);
            this.Content = panel;
        }
    }
}
