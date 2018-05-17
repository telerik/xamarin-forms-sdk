using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.LayoutsCategory.GridLayoutExample
{
    public class DataFormGridLayoutCSharp : ContentView
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
