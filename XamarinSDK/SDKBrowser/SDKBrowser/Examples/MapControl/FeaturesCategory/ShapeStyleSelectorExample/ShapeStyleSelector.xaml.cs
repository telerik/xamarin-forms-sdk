using Telerik.XamarinForms.Map;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MapControl.FeaturesCategory.ShapeStyleSelectorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShapeStyleSelector : ContentView
    {
        public ShapeStyleSelector()
        {
            InitializeComponent();

            var assembly = this.GetType().Assembly;
            var source = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.shp", assembly);
            var dataSource = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.dbf", assembly);
            this.reader.Source = source;
            this.reader.DataSource = dataSource;
        }
    }
}