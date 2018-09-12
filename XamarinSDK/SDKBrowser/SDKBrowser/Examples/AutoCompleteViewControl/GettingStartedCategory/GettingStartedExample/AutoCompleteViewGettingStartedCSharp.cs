using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.AutoCompleteViewControl.GettingStartedCategory.GettingStartedExample
{
    public class AutoCompleteViewGettingStartedCSharp : ContentView
    {
        public AutoCompleteViewGettingStartedCSharp()
        {
            // >> autocompleteview-getting-started-csharp
            var autoCompleteView = new RadAutoCompleteView { Watermark = "Search here..." };
            // << autocompleteview-getting-started-csharp
            autoCompleteView.ItemsSource = new List<string>()
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

            var panel = new StackLayout();
            panel.Children.Add(autoCompleteView);
            this.Content = panel;
           
        }
    }
}