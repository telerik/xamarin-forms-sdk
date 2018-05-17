using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.ReadonlyExample
{
    public class DataFormDataAnnotationsReadonlyCSharp : ContentView
    {
        public DataFormDataAnnotationsReadonlyCSharp()
        {
            // >> dataform-dataannotations-readonly-form
            var dataForm = new RadDataForm
            {
                Source = new Employee()
            };
            // << dataform-dataannotations-readonly-form

            Content = dataForm;
        }
    }
}

