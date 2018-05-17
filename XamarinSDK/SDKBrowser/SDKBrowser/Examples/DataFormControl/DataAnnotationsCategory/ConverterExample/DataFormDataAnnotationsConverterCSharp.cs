using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.ConverterExample
{
    public class DataFormDataAnnotationsConverterCSharp : ContentView
    {
        public DataFormDataAnnotationsConverterCSharp()
        {
            // >> dataform-dataannotations-converter-form
            var dataForm = new RadDataForm
            {
                Source = new Item()
            };

            dataForm.RegisterEditor("Price", EditorType.NumberPickerEditor);
            // << dataform-dataannotations-converter-form

            Content = dataForm;
        }
    }
}

