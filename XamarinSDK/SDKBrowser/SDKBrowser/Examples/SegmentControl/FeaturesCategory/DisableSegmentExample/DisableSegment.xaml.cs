using Xamarin.Forms;

namespace SDKBrowser.Examples.SegmentControl.FeaturesCategory.DisableSegmentExample
{
    public partial class DisableSegment : ContentView
    {
        public DisableSegment()
        {
            this.InitializeComponent();

            // >> segmentcontrol-features-disablesegment-csharp
            this.segmentControl.SetSegmentEnabled(2, false);
            // << segmentcontrol-features-disablesegment-csharp
        }
    }
}
