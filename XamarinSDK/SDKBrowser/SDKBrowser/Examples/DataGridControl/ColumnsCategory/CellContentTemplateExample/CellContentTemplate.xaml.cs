using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.ColumnsCategory.CellContentTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CellContentTemplate : ContentView
    {
        public CellContentTemplate()
        {
            InitializeComponent();

            this.BindingContext = new ColumnsViewModel();
        }
    }
}