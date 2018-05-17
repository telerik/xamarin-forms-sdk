using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.DisplayOptionsExample
{
    public class DataFormDataAnnotationsDisplayOptionsCSharp : ContentView
    {
        public DataFormDataAnnotationsDisplayOptionsCSharp()
        {
            // >> dataform-dataannotations-displayoptions-form
            var dataForm = new RadDataForm
            {
                Source = new Person()
            };

            dataForm.RegisterEditor("Weight", EditorType.DecimalEditor);
            dataForm.RegisterEditor("Age", EditorType.IntegerEditor);
            // << dataform-dataannotations-displayoptions-form

            Content = dataForm;
        }
    }
}

