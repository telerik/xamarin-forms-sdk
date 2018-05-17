using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.DataSourceKeyExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFormDataAnnotationsDataSourceKeyXaml : ContentView
    {
        public DataFormDataAnnotationsDataSourceKeyXaml()
        {
            this.InitializeComponent();

            this.dataForm.RegisterEditor("Location", EditorType.PickerEditor);
        }
    }
}
