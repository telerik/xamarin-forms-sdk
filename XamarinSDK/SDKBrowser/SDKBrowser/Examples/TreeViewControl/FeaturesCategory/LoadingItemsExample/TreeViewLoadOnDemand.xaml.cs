using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.LoadingItemsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreeViewLoadOnDemand : ContentView
    {
        public TreeViewLoadOnDemand()
        {
            InitializeComponent();
            // >> treeview-loadondemand-setviewmodel
            this.BindingContext = new ViewModel();
            // << treeview-loadondemand-setviewmodel
        }
    }
}