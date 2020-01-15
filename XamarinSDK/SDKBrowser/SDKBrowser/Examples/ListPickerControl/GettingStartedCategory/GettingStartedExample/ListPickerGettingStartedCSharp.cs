using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListPickerControl.GettingStartedCategory.GettingStartedExample
{
    public class ListPickerGettingStartedCSharp : ContentView
    {
        public ListPickerGettingStartedCSharp()
        {
            // >> listpicker-getting-started-csharp
            this.BindingContext = new ViewModel();
            var listPicker = new RadListPicker()
            {
                Placeholder = "Pick a name!",
                ItemTemplate = new DataTemplate(() =>
                {
                    var label = new Label
                    {
                        VerticalTextAlignment = TextAlignment.Center,
                        HorizontalTextAlignment = TextAlignment.Center
                    };
                    label.SetBinding(Label.TextProperty, new Binding(nameof(Person.Name)));

                    return label;
                }),
                DisplayMemberPath = "FullName"
            };
            listPicker.SetBinding(RadListPicker.ItemsSourceProperty, new Binding("Items"));
            // << listpicker-getting-started-csharp
            var panel = new StackLayout();
            panel.Children.Add(listPicker);
            this.Content = panel;
        }
    }
}
