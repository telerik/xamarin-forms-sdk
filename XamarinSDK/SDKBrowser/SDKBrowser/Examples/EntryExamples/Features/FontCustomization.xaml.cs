using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.EntryExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FontCustomization : ContentPage
    {
        public FontCustomization()
        {
            InitializeComponent();
            this.smallEntry.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
        }
    }
}