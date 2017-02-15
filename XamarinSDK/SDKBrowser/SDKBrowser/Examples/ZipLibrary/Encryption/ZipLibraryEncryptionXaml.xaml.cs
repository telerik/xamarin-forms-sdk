using Xamarin.Forms;

namespace SDKBrowser.Examples.ZipLibrary
{
	public partial class ZipLibraryEncryptionXaml : ContentPage
	{
		public ZipLibraryEncryptionXaml()
		{
            this.BindingContext = new GettingStarted.ViewModel();

			InitializeComponent();
		}
	}
}
