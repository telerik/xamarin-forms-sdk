using Telerik.XamarinForms.Map;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MapControl.FeaturesCategory.ShapeLabelStyleExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShapeLabelStyle : ContentView
    {
        public ShapeLabelStyle()
        {
            InitializeComponent();

            var source = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.shp");
            var dataSource = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.dbf");
            this.reader.Source = source;
            this.reader.DataSource = dataSource;
        }
    }
}