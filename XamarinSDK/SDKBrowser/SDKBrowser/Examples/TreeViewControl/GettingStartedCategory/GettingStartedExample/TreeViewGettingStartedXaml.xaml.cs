using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.GettingStartedCategory.GettingStartedExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreeViewGettingStartedXaml : ContentView
    {
       
        public TreeViewGettingStartedXaml()
        {
            InitializeComponent();
            // >> treeview-getting-started-setviewmodel
            this.BindingContext = new ViewModel();
            // << treeview-getting-started-setviewmodel
        }
    }
}