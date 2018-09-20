using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.NestedPropertyExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NestedProperty : ContentView
    {
        public NestedProperty()
        {
            InitializeComponent();

            this.BindingContext = new NestedPropertyViewModel();
        }
    }
}
