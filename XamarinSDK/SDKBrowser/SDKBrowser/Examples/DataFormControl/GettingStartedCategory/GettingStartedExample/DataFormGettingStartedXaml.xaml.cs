using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.GettingStartedCategory.GettingStartedExample
{
    public partial class DataFormGettingStartedXaml : ContentView
    {
        public DataFormGettingStartedXaml()
        {
            this.InitializeComponent();

            dataForm.RegisterEditor(nameof(SourceItem.Age), EditorType.IntegerEditor);
            dataForm.RegisterEditor(nameof(SourceItem.Name), EditorType.TextEditor);
            dataForm.RegisterEditor(nameof(SourceItem.Weight), EditorType.DecimalEditor);
            dataForm.RegisterEditor(nameof(SourceItem.Height), EditorType.IntegerEditor);
        }
    }
}
