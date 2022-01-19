using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.DataTableCategory.CommandsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Commands : ContentView
    {
        DataTableViewModel viewModel;
        public Commands()
        {
            InitializeComponent();
            this.viewModel = new DataTableViewModel();
            this.BindingContext = viewModel;
        }
    }
}