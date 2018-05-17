using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.EditorsCategory.CustomEditorExample
{
    public partial class CustomDataFormEditor : ContentView
    {
        public CustomDataFormEditor()
        {
            this.InitializeComponent();

            this.dataForm.RegisterEditor("Option", EditorType.Custom);
        }
    }
}