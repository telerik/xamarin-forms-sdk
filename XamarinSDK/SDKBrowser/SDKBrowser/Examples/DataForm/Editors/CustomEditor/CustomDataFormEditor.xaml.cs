using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public partial class CustomDataFormEditor : ContentPage
    {
        public CustomDataFormEditor()
        {
            InitializeComponent();

            this.dataForm.RegisterEditor("Option", EditorType.Custom);
        }
    }
}