using Xamarin.Forms;

namespace SDKBrowser.Examples.SpreadStreamProcessing
{
    public partial class SpreadStreamProcessingGettingStartedXaml : ContentPage
	{
		public SpreadStreamProcessingGettingStartedXaml()
		{
            this.BindingContext = new GettingStarted.GettingStartedViewModel();

			InitializeComponent();
		}
    }
}
