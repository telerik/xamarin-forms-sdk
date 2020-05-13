using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.ColumnsCategory.CellEditTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CellEditTemplate : ContentView
    {
        public CellEditTemplate()
        {
            InitializeComponent();

            this.BindingContext = new ColumnsViewModel();
        }
    }
}