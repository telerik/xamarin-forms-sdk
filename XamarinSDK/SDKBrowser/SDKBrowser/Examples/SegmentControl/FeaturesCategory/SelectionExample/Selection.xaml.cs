using Xamarin.Forms;

namespace SDKBrowser.Examples.SegmentControl.FeaturesCategory.SelectionExample
{
    public partial class Selection : ContentView
    {
        public Selection()
        {
            this.InitializeComponent();

            // >> segmentcontrol-features-selection-setviewmodel
            this.segmentControl.BindingContext = new ViewModel();
            // << segmentcontrol-features-selection-setviewmodel
        }
    }
}
