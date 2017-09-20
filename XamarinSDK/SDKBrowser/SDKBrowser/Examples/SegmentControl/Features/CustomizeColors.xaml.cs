
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.SegmentControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomizeColors : ContentPage
    {
        public CustomizeColors()
        {
            InitializeComponent();
            // >> segmentcontrol-features-customizecolors-csharp
            this.segmentControl.SetSegmentEnabled(2, false);
            // << segmentcontrol-features-customizecolors-csharp
        }
    }
}
