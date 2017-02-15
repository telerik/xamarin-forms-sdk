using Xamarin.Forms;
using Telerik.XamarinForms.Input;
using SDKBrowser.Examples.DataForm.DataAnnotations.Readonly;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormDataAnnotationsReadonly : ContentPage
    {
        public DataFormDataAnnotationsReadonly()
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

