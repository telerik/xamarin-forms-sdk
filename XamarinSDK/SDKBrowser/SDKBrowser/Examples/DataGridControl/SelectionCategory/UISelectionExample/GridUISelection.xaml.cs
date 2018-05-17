using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.SelectionCategory.UISelectionExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridUISelection : ContentView
    {
        public GridUISelection()
        {
            this.InitializeComponent();

            this.BindingContext = new ViewModel();
        }
    }
}