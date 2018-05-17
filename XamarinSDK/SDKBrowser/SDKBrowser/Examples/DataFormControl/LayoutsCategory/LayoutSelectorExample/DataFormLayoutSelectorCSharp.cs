using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.LayoutsCategory.LayoutSelectorExample
{
    public class DataFormLayoutSelectorCSharp : ContentView
    {
        public DataFormLayoutSelectorCSharp()
        {
            // >> dataform-grouplayouts-layoutselector-csharp
            var dataForm = new RadDataForm
            {
                Source = new SourceItem(),
                GroupLayoutDefinitionSelector = new CustomGroupLayoutDefinitionSelector()
            };
            // << dataform-grouplayouts-layoutselector-csharp

            this.Content = dataForm;
        }
    }
}


