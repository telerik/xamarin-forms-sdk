using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChatControl.FeaturesCategory.CommandsExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Commands : ContentView
	{
		public Commands ()
		{
			InitializeComponent ();

            this.BindingContext = new ViewModel();
		}
	}
}