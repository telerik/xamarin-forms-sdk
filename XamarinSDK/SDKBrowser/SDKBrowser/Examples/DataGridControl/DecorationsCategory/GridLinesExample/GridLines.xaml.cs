using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.DecorationsCategory.GridLinesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLines : ContentView
    {
        public GridLines()
        {
            this.InitializeComponent();

            this.BindingContext = new ViewModel();
        }
    }
}