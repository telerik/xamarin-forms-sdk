using Xamarin.Forms;
using Telerik.XamarinForms.Input;
using SDKBrowser.Examples.DataForm.DataAnnotations.DisplayOptions;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormDataAnnotationsDisplayOptions : ContentPage
    {
        public DataFormDataAnnotationsDisplayOptions()
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

