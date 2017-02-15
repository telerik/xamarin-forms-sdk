using SDKBrowser.Examples.DataForm;
using SDKBrowser.Examples.DataForm.GroupLayouts.GridLayout;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormGridLayoutCSharp : ContentPage
    {
        public DataFormGridLayoutCSharp()
        {
            // >> dataform-grouplayouts-gridlayout-csharp

            var dataForm = new RadDataForm
            {
                GroupLayoutDefinition = new DataFormGroupGridLayoutDefinition(),
                Source = new SourceItem()
            };

            // << dataform-grouplayouts-gridlayout-csharp

            Content = dataForm;
        }
    }
}
