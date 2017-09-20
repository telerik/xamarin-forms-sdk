using Xamarin.Forms;

namespace SDKBrowser.Examples.SegmentControl
{
    public partial class DisableSegment : ContentPage
    {
        public DisableSegment()
        {
            InitializeComponent();

            // >> segmentcontrol-features-disablesegment-csharp            
            this.segmentControl.SetSegmentEnabled(2, false);
            // << segmentcontrol-features-disablesegment-csharp            
        }
    }
}
