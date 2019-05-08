using Telerik.XamarinForms.Map;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MapControl.FeaturesCategory.ShapeStyleExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShapeStyle : ContentView
    {
        public ShapeStyle()
        {
            InitializeComponent();

            var source = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.shp");
            this.reader.Source = source;
        }
    }
}