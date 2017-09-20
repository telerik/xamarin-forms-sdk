using SDKBrowser.Examples.DataForm.Editors.CustomEditor;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public partial class CustomDataFormEditor : ContentPage
    {
        public CustomDataFormEditor()
        {
            InitializeComponent();
            this.BindingContext = new SourceItem();
            this.dataForm.CommitMode = CommitMode.Immediate;
            this.dataForm.ValidationMode = ValidationMode.Manual;

            this.dataForm.RegisterEditor("Option", EditorType.Custom);
        }
    }
}