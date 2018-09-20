using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.CustomFilteringExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomFiltering : ContentView
    {
        public CustomFiltering ()
        {
            InitializeComponent ();

            this.BindingContext = new CustomFilteringViewModel();
        }
    }
}
