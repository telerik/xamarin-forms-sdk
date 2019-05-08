using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataFormControl.HowToCategory.AutoCompleteEditorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFormAutoCompleteEditor : ContentView
    {
        public DataFormAutoCompleteEditor()
        {
            this.InitializeComponent();

            // >> dataform-howto-autocompleteeditor-csharp
            this.dataForm.RegisterEditor("City", EditorType.Custom);
            // << dataform-howto-autocompleteeditor-csharp
        }
    }
}
