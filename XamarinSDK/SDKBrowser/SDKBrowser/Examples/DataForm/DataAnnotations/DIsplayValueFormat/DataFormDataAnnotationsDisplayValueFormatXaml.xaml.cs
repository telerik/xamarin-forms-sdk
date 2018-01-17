using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFormDataAnnotationsDisplayValueFormatXaml : ContentPage
    {
        public DataFormDataAnnotationsDisplayValueFormatXaml()
        {
            this.InitializeComponent();

            this.dataForm.RegisterEditor("Votes", EditorType.NumberPickerEditor);
            this.dataForm.RegisterEditor("Date", EditorType.DateEditor);
        }
    }
}
