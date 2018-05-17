using Xamarin.Forms;

namespace SDKBrowser.Examples.ZipLibraryControl.EncryptionCategory.EncryptionExample
{
    public partial class ZipLibraryEncryptionXaml : ContentView
    {
        public ZipLibraryEncryptionXaml()
        {
            this.InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}
