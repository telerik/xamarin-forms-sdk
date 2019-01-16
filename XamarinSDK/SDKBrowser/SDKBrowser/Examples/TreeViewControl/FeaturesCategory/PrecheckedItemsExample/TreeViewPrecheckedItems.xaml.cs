using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.PrecheckedItemsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreeViewPrecheckedItems : ContentView
    {
        public TreeViewPrecheckedItems()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel(3, 5);
        }
    }
}