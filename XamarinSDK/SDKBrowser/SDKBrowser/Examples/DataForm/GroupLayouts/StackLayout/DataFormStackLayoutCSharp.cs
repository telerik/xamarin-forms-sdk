using SDKBrowser.Examples.DataForm.GroupLayouts.StackLayout;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormStackLayoutCSharp : ContentPage
    {
        public DataFormStackLayoutCSharp()
        {
            // >> dataform-grouplayouts-stacklayout-csharp

            var dataForm = new RadDataForm
            {
                GroupLayoutDefinition = new DataFormGroupStackLayoutDefinition(),
                Source = new SourceItem()
            };

            // << dataform-grouplayouts-stacklayout-csharp

            Content = dataForm;
        }
    }
}


