using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.ConverterExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFormDataAnnotationsConverterXaml : ContentView
    {
        public DataFormDataAnnotationsConverterXaml()
        {
            this.InitializeComponent();

            this.dataForm.RegisterEditor("Price", EditorType.NumberPickerEditor);
        }
    }
}
