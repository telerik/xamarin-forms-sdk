using System;

using Xamarin.Forms;
using Telerik.XamarinForms.Input;
using SDKBrowser.Examples.DataForm.GroupLayouts.LayoutSelector;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormLayoutSelectorCSharp : ContentPage
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


