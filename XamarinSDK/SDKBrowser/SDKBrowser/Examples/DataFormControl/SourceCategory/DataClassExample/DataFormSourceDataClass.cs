using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataFormControl.SourceCategory.DataClassExample
{
    public class DataFormSourceDataClass : ContentView
    {
        public DataFormSourceDataClass()
        {
            // >> dataform-source-dataclass-dataform
            var dataForm = new RadDataForm
            {
                Source = new Customer()
            };
            // << dataform-source-dataclass-dataform

            Content = dataForm;
        }
    }
}

