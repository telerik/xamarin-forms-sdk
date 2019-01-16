using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.StylingCategory.ItemStyleSelectorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreeViewItemStyleSelector : ContentView
    {
        public TreeViewItemStyleSelector()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}