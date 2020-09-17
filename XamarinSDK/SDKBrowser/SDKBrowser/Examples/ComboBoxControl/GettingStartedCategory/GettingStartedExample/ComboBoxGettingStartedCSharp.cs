using System.Collections.ObjectModel;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ComboBoxControl.GettingStartedCategory.GettingStartedExample
{
    public class ComboBoxGettingStartedCSharp : ContentView
    {
        ViewModel vm;
        public ComboBoxGettingStartedCSharp()
        {
            this.vm = new ViewModel();
            this.BindingContext = vm;
            var lbl1 = new Label 
            { 
                Text = "ComboBox with static items", 
                Margin = new Thickness(0, 0, 0, 5) 
            };
            // >> combobox-getting-started-static-items-csharp
            var combobox = new RadComboBox();

            combobox.ItemsSource = new string[]
            {
                "USA",
                "Uganda",
                "Ukraine",
                "Canada",
                "France",
                "Italy",
                "United Kingdom",
                "China",
                "Japan",
            };
            // << combobox-getting-started-static-items-csharp

            var lbl2 = new Label 
            { 
                Text = "ComboBox with binding to a complex object using DisplayMemberPath property", 
                Margin = new Thickness(0, 20, 0, 5) 
            };

            // >> combobox-getting-started-complex-object-csharp
            var comboBox = new RadComboBox();
            comboBox.ItemsSource = this.vm.Items;
            comboBox.DisplayMemberPath = "Population";
            // << combobox-getting-started-complex-object-csharp

            var panel = new StackLayout();
            panel.Children.Add(lbl1);
            panel.Children.Add(combobox);
            panel.Children.Add(lbl2);
            panel.Children.Add(comboBox);
            this.Content = panel;
        }
    }
}
