using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFormDataAnnotationsConverterXaml : ContentPage
    {
        public DataFormDataAnnotationsConverterXaml()
        {
            this.InitializeComponent();

            this.dataForm.RegisterEditor("Price", EditorType.NumberPickerEditor);
        }
    }
}
