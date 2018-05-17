using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.DisplayValueFormatExample
{
    public class DataFormDataAnnotationsDisplayValueFormatCSharp : ContentView
    {
        public DataFormDataAnnotationsDisplayValueFormatCSharp()
        {
            // >> dataform-dataannotations-displayvalueformat-form
            var dataForm = new RadDataForm
            {
                Source = new VoteResults()
            };

            dataForm.RegisterEditor("Votes", EditorType.NumberPickerEditor);
            dataForm.RegisterEditor("Date", EditorType.DateEditor);
            // << dataform-dataannotations-displayvalueformat-form

            this.Content = dataForm;
        }
    }
}
