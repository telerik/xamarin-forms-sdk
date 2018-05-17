using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.LoadOnDemandCategory.LoadOnDemandExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadOnDemand : ContentView
    {
        public LoadOnDemand()
        {
            this.InitializeComponent();

            this.BindingContext = new LoadOnDemandViewModel();
        }
    }
}