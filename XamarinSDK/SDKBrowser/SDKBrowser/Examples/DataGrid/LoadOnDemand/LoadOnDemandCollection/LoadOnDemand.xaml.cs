using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGrid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadOnDemand : ContentPage
    {
        public LoadOnDemand()
        {
            InitializeComponent();

            this.BindingContext = new LoadOnDemandViewModel();
        }
    }
}