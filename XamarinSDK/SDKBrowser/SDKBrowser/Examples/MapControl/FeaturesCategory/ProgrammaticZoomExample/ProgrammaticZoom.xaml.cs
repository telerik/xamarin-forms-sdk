using Telerik.XamarinForms.Map;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MapControl.FeaturesCategory.ProgrammaticZoomExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgrammaticZoom : ContentView
    {
        public ProgrammaticZoom()
        {
            InitializeComponent();

            var source = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.shp");
            this.reader.Source = source;
        }

        private void OnEntryCompleted(object sender, System.EventArgs e)
        {
            var text = this.zoomLevelEntry.Text;
            int zoomLevel;
            if (int.TryParse(text, out zoomLevel))
            {
                this.map.ZoomToLevel(zoomLevel);
            }
        }
    }
}