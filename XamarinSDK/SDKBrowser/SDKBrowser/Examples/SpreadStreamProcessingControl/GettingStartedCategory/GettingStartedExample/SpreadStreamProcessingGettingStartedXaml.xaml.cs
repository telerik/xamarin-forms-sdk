using Xamarin.Forms;

namespace SDKBrowser.Examples.SpreadStreamProcessingControl.GettingStartedCategory.GettingStartedExample
{
    public partial class SpreadStreamProcessingGettingStartedXaml : ContentView
	{
		public SpreadStreamProcessingGettingStartedXaml()
		{
            this.BindingContext = new GettingStartedViewModel();

			InitializeComponent();
		}
    }
}
