using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.CommandsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreeViewCommands : ContentView
    {
        public TreeViewCommands ()
		{
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}