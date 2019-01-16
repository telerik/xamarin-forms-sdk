using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.ItemTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemTemplate : ContentView
    {
        public ItemTemplate()
        {
            InitializeComponent();
            // >> treeview-itemtemplate-setviewmodel
            this.BindingContext = new ViewModel();
            // << treeview-itemtemplate-setviewmodel
        }
    }
}