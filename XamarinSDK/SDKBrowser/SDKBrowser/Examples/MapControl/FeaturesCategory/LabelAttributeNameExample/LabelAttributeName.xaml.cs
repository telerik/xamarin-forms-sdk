using System;
using Telerik.XamarinForms.Map;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MapControl.FeaturesCategory.LabelAttributeNameExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelAttributeName : ContentView
    {
        public LabelAttributeName()
        {
            InitializeComponent();

            // >> map-labels-settintsource
            var source = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.shp");
            var dataSource = MapSource.FromResource("SDKBrowser.Examples.MapControl.world.dbf");
            this.reader.Source = source;
            this.reader.DataSource = dataSource;
            // << map-labels-settintsource
        }

        private void OnChangeLabelAttributeNameClicked(object sender, EventArgs e)
        {
            if (this.mapShapeLayer.LabelAttributeName == "CNTRY_NAME")
            {
                this.mapShapeLayer.LabelAttributeName = "ISO_3DIGIT";
            }
            else
            {
                this.mapShapeLayer.LabelAttributeName = "CNTRY_NAME";
            }
        }
    }
}