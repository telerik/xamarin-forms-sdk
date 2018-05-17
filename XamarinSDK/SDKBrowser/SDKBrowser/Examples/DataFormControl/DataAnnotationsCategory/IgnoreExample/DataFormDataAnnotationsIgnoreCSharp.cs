using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.IgnoreExample
{
    public class DataFormDataAnnotationsIgnoreCSharp : ContentView
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

