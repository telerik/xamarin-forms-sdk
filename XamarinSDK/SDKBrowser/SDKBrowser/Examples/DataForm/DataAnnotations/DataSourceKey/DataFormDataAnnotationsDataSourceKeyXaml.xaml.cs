using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFormDataAnnotationsDataSourceKeyXaml : ContentPage
    {
        public DataFormDataAnnotationsDataSourceKeyXaml()
        {
            this.InitializeComponent();

            this.dataForm.RegisterEditor("Location", EditorType.PickerEditor);
        }
    }
}
