using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.LayoutsCategory.StackLayoutExample
{
    public class DataFormStackLayoutCSharp : ContentView
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


