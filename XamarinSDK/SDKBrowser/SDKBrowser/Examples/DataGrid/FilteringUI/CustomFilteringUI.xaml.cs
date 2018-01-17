using SDKBrowser.Examples.DataGrid.FilteringUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomFilteringUI : ContentPage
    {
        public CustomFilteringUI()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();
            this.grid.Commands.Add(new CustomOptionsTapCommand());
        }
    }
}