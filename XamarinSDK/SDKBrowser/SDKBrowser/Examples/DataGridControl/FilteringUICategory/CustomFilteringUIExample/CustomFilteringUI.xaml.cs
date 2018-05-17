using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.FilteringUICategory.CustomFilteringUIExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomFilteringUI : ContentView
    {
        public CustomFilteringUI()
        {
            this.InitializeComponent();

            this.BindingContext = new ViewModel();
            this.grid.Commands.Add(new CustomOptionsTapCommand());
        }
    }
}