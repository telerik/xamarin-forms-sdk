using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.FirstLookExample
{
    public partial class FirstLook : ContentView
    {
        public FirstLook()
        {
            this.InitializeComponent();
            this.BindingContext = new FirstLookViewModel();
        }
    }
}