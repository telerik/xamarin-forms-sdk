using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.ColumnsCategory.ColumnsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Columns : ContentView
    {
        public Columns()
        {
            InitializeComponent();
            this.BindingContext = new ColumnsViewModel();
        }
    }
}