using System;
using Telerik.XamarinForms.Map;
using Telerik.XamarinForms.ShapefileReader;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MapControl.FeaturesCategory.SetBestViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetBestView : ContentView
    {
        public SetBestView()
        {
            InitializeComponent();

            var source = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.shp");
            this.reader.Source = source;
        }

        private void OnSetBestViewClicked(object sender, EventArgs e)
        {
            // >> map-setbestview-code
            var bestView = this.mapShapeLayer.GetBestView();
            this.map.SetView(bestView);
            // << map-setbestview-code
        }

        private void OnSetViewItalyClicked(object sender, EventArgs e)
        {
            // >> map-setview-code
            var northWest = new Location(45.7, 4.8);
            var southEast = new Location(37.7, 20.08);
            var view = new LocationRect(northWest, southEast);
            this.map.SetView(view);
            // << map-setview-code
        }
    }
}