using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.LoadOnDemandCategory.LoadOnDemandCustomizationsExample
{
    public partial class LoadOnDemandCustomizations : ContentView
    {
        public LoadOnDemandCustomizations()
        {
            this.InitializeComponent();

            this.BindingContext = new ListViewModel();
        }
    }
}
