using SDKBrowser.Examples.DataForm.DataAnnotations.Ignore;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormDataAnnotationsIgnoreCSharp : ContentPage
    {
        public DataFormDataAnnotationsIgnoreCSharp()
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

