using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.AutoComplete
{
    public class AutoCompleteGettingStartedCSharp : ContentPage
    {
        public AutoCompleteGettingStartedCSharp()
        {
            // >> autocomplete-getting-started-csharp
            var autoComplete = new RadAutoComplete { BackgroundColor = Color.White };
            // << autocomplete-getting-started-csharp

            autoComplete.ItemsSource = new List<string>()
            {
                "Freda Curtis",
                "Jeffery Francis",
                "Eva Lawson",
                "Emmett Santos",
                "Theresa Bryan",
                "Jenny Fuller",
                "Terrell Norris",
                "Eric Wheeler",
                "Julius Clayton",
                "Alfredo Thornton",
                "Roberto Romero",
                "Orlando Mathis",
                "Eduardo Thomas",
                "Harry Douglas"
            };

            var panel = new StackLayout { BackgroundColor = Color.Silver };
            panel.Children.Add(autoComplete);
            this.Content = panel;
        }
    }
}