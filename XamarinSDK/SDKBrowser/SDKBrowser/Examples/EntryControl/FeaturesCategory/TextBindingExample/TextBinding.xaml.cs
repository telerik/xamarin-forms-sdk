using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.EntryControl.FeaturesCategory.TextBindingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextBinding : ContentView
    {
        public TextBinding()
        {
            InitializeComponent();

            // >> entry-textbinding-setviewmodel
            this.BindingContext = new ViewModel();
            // << entry-textbinding-setviewmodel
        }
    }
}