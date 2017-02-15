using Xamarin.Forms;

namespace SDKBrowser.Examples.SpreadStreamProcessing
{
    public partial class Styling : ContentPage
    {
        public Styling()
        {
            this.BindingContext = new GettingStarted.StylingViewViewModel();

            InitializeComponent();
        }
    }
}
