using SDKBrowser.Examples.DataForm.DataAnnotations.Ignore;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormDataAnnotationsIgnore : ContentPage
    {
        public DataFormDataAnnotationsIgnore()
        {
            // >> dataform-dataannotations-ignore-form
            var dataForm = new RadDataForm
            {
                Source = new Person()
            };
            // << dataform-dataannotations-ignore-form

            Content = dataForm;
        }
    }
}

