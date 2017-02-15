using Xamarin.Forms;
using SDKBrowser.Examples.DataForm.DataAnnotations.DisplayValueFormat;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormDataAnnotationsDisplayValueFormat : ContentPage
    {
        public DataFormDataAnnotationsDisplayValueFormat()
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

