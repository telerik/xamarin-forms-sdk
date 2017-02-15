using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataVisualization.Gauges;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Gauge
{
    public partial class CustomShapes : ContentPage
    {
        public CustomShapes()
        {
            InitializeComponent();

            this.pickerIndicators.Items.Add("Default");
            this.pickerIndicators.Items.Add("Shape1");
            this.pickerIndicators.Items.Add("Shape2");
            this.pickerIndicators.Items.Add("Shape3");
            this.pickerIndicators.SelectedIndex = 0;
        }

        private void PickerIndicatorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GaugeShapeIndicator shapeIndicator = (GaugeShapeIndicator)this.gauge1.Indicators[0];
            string shapeName = this.pickerIndicators.Items[this.pickerIndicators.SelectedIndex];

            this.UpdateShapeGeometry(shapeIndicator, shapeName);
            this.UpdateShapeStroke(shapeIndicator, shapeName);
        }

        private void UpdateShapeGeometry(GaugeShapeIndicator shapeIndicator, string shapeName)
        {
            object shapeGeometryObject;
            this.Resources.TryGetValue(shapeName, out shapeGeometryObject);
            RadPathGeometry shapeGeometry = shapeGeometryObject as RadPathGeometry;
            if (shapeGeometry != null)
            {
                shapeIndicator.Shape = shapeGeometry;
            }
            else
            {
                shapeIndicator.ClearValue(GaugeShapeIndicator.ShapeProperty);
            }
        }

        private void UpdateShapeStroke(GaugeShapeIndicator shapeIndicator, string shapeName)
        {
            if (shapeName == "Shape2" || shapeName == "Shape3")
            {
                shapeIndicator.Stroke = Color.Red;
                shapeIndicator.StrokeThickness = 2;
            }
            else
            {
                shapeIndicator.Stroke = Color.Default;
                shapeIndicator.StrokeThickness = 0;
            }
        }
    }
}
