using SDKBrowser.Examples.DataGrid.Selection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridUISelection : ContentPage
    {
        public GridUISelection()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();
        }
    }
}