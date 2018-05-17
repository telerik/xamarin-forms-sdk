using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.EntryControl.FeaturesCategory.FontCustomizationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FontCustomization : ContentView
    {
        public FontCustomization()
        {
            this.InitializeComponent();
            this.smallEntry.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
        }
    }
}