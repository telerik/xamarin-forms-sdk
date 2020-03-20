using Telerik.XamarinForms.Map;
using Xamarin.Forms;

namespace SDKBrowser.Examples.MapControl.GettingStartedCategory.GettingStartedExample
{
	public class MapGettingStartedCSharp : ContentView
	{
        public MapGettingStartedCSharp()
        {
            // >> map-gettingstarted-csharp
            var map = new RadMap();

            var assembly = this.GetType().Assembly;
            var shapeFileLayer = new ShapefileLayer()
            {
                Reader = new MapShapeReader() { Source = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.shp", assembly) }
            };
            map.Layers.Add(shapeFileLayer);
            // << map-gettingstarted-csharp

            Content = map;
        }
    }
}