using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.StylingCategory.StylingGroupsExample
{
    public class DataFormStylingGroupsCSharp : ContentView
    {
        public DataFormStylingGroupsCSharp()
        {
            // >> dataform-styling-groups-csharp
            var groupHeaderStyle = new DataFormGroupHeaderStyle
            {
                Background = Color.FromHex("#90C9E9"),
                Foreground = Color.Black,
                Height = 60,
                Padding = new Thickness(20),
                TextAlignment = TextAlignment.Center
            };

            var dataForm = new RadDataForm
            {
                Source = new Customer(),
                GroupHeaderStyle = groupHeaderStyle
            };
            // << dataform-styling-groups-csharp

            Content = dataForm;
        }
    }
}


