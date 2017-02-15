using Xamarin.Forms;
using Telerik.XamarinForms.Input;
using SDKBrowser.Examples.DataForm.GettingStarted;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormGettingStartedCSharp : ContentPage
    {
        public DataFormGettingStartedCSharp()
        {
            // >> dataform-gettingstarted-setup-csharp
            var dataForm = new RadDataForm
            {
                Source = new SourceItem()
            };
            // << dataform-gettingstarted-setup-csharp

            // >> dataform-gettingstarted-register-editors
            dataForm.RegisterEditor(nameof(SourceItem.Age), EditorType.IntegerEditor);
            dataForm.RegisterEditor(nameof(SourceItem.Name), EditorType.TextEditor);
            dataForm.RegisterEditor(nameof(SourceItem.Weight), EditorType.DecimalEditor);
            dataForm.RegisterEditor(nameof(SourceItem.Height), EditorType.IntegerEditor);
            // << dataform-gettingstarted-register-editors

            Content = dataForm;
        }
    }
}
