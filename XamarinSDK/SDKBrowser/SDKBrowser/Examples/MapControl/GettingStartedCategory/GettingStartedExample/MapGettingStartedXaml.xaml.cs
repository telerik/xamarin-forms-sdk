using Telerik.XamarinForms.Map;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MapControl.GettingStartedCategory.GettingStartedExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapGettingStartedXaml : ContentView
    {
        public MapGettingStartedXaml()
        {
            InitializeComponent();

            // >> map-gettingstarted-setting-source
            var source = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.shp");
            this.reader.Source = source;
            // << map-gettingstarted-setting-source
        }
    }
}