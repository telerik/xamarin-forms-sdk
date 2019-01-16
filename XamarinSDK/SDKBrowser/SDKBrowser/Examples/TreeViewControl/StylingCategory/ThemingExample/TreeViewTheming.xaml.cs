using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.StylingCategory.ThemingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreeViewTheming : ContentView
    {
        public TreeViewTheming()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}