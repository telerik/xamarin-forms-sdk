using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataVisualization.Gauges;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Gauge
{
    public partial class CustomNeedlesXaml : ContentPage
    {
        public CustomNeedlesXaml()
        {
            InitializeComponent();

            this.pickerIndicators.Items.Add("Default");
            this.pickerIndicators.Items.Add("Needle1");
            this.pickerIndicators.Items.Add("Needle2");
            this.pickerIndicators.Items.Add("Needle3");
            this.pickerIndicators.SelectedIndex = 0;
        }

        private void PickerIndicatorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GaugeNeedleIndicator needle = (GaugeNeedleIndicator)this.gauge1.Indicators[0];
            string needleName = this.pickerIndicators.Items[this.pickerIndicators.SelectedIndex];

            this.UpdateNeedleGeometry(needle, needleName);
            this.UpdateNeedleStroke(needle, needleName);
        }

        private void UpdateNeedleGeometry(GaugeNeedleIndicator needle, string needleName)
        {
            object needleGeometryObject;
            this.Resources.TryGetValue(needleName, out needleGeometryObject);
            RadPathGeometry needleGeometry = needleGeometryObject as RadPathGeometry;
            if (needleGeometry != null)
            {
                needle.Shape = needleGeometry;
            }
            else
            {
                needle.ClearValue(GaugeNeedleIndicator.ShapeProperty);
            }
        }

        private void UpdateNeedleStroke(GaugeNeedleIndicator needle, string needleName)
        {
            if (needleName == "Needle1")
            {
                needle.Stroke = Color.Red;
                needle.StrokeThickness = 3;
            }
            else if (needleName == "Needle2")
            {
                needle.Stroke = Color.Red;
                needle.StrokeThickness = 2;
            }
            else
            {
                needle.Stroke = Color.Default;
                needle.StrokeThickness = 0;
            }
        }
    }
}
