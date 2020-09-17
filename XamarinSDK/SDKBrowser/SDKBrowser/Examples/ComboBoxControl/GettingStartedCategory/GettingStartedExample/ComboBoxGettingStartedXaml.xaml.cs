using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ComboBoxControl.GettingStartedCategory.GettingStartedExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComboBoxGettingStartedXaml : ContentView
    {
        public ComboBoxGettingStartedXaml()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}