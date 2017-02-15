using SDKBrowser.Examples.DataForm.GettingStarted;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public partial class DataFormGettingStartedXaml : ContentPage
    {
        public DataFormGettingStartedXaml()
        {
            InitializeComponent();

            dataForm.RegisterEditor(nameof(SourceItem.Age), EditorType.IntegerEditor);
            dataForm.RegisterEditor(nameof(SourceItem.Name), EditorType.TextEditor);
            dataForm.RegisterEditor(nameof(SourceItem.Weight), EditorType.DecimalEditor);
            dataForm.RegisterEditor(nameof(SourceItem.Height), EditorType.IntegerEditor);
        }
    }
}
