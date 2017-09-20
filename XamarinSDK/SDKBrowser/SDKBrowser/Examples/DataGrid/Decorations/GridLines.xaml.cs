using SDKBrowser.Examples.DataGrid.Decorations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLines : ContentPage
    {
        public GridLines()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();
        }
    }
}