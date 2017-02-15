using Xamarin.Forms;
using Telerik.XamarinForms.Input;
using SDKBrowser.Examples.DataForm.Styling.Groups;
using Telerik.XamarinForms.Input.DataForm;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormStylingGroupsCSharp : ContentPage
    {
        public DataFormStylingGroupsCSharp()
        {
            // >> dataform-styling-groups-csharp
            var groupHeaderStyle = new DataFormGroupHeaderStyle
            {
                Background = Color.FromHex("#FFC300"),
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


