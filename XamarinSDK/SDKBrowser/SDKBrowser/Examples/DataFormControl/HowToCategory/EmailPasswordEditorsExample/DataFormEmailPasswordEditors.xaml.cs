using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataFormControl.HowToCategory.EmailPasswordEditorsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFormEmailPasswordEditors : ContentView
    {
        public DataFormEmailPasswordEditors ()
        {
            InitializeComponent ();

            // >> dataform-howto-emailpasswordeditors-code
            dataForm.Source = new Account();

            dataForm.RegisterEditor("Email", EditorType.Custom);
            dataForm.RegisterEditor("Password", EditorType.Custom);
            dataForm.RegisterEditor("Date", EditorType.DateEditor);
            // << dataform-howto-emailpasswordeditors-code
        }
    }
}