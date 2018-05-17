using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.SegmentControl.FeaturesCategory.CustomizeColorsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomizeColors : ContentView
    {
        public CustomizeColors()
        {
            this.InitializeComponent();
            // >> segmentcontrol-features-customizecolors-csharp
            this.segmentControl.SetSegmentEnabled(2, false);
            // << segmentcontrol-features-customizecolors-csharp
        }
    }
}
