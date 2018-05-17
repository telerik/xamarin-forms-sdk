using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.DisplayOptionsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFormDataAnnotationsDisplayOptionsXaml : ContentView
    {
        public DataFormDataAnnotationsDisplayOptionsXaml()
        {
            this.InitializeComponent();

            this.dataForm.RegisterEditor("Weight", EditorType.DecimalEditor);
            this.dataForm.RegisterEditor("Age", EditorType.IntegerEditor);
        }
    }
}
