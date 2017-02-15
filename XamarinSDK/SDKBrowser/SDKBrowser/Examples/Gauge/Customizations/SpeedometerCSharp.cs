using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataVisualization.Gauges;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Gauge
{
    public class SpeedometerCSharp : ContentPage
    {
        public SpeedometerCSharp()
        {
            this.BackgroundColor = Color.White;

            RadRadialGauge gauge = new RadRadialGauge();
            gauge.Axis = new GaugeLinearAxis
            {
                Minimum = 0,
                Maximum = 180,
                Step = 20,
                TickPosition = GaugeElementPosition.Start,
                LabelPosition = GaugeElementPosition.Start,
                StrokeThickness = 0,
                TickThickness = 2
            };

            RadPathFigure needleFigure = new RadPathFigure();
            needleFigure.StartPoint = new Point(1, 0.5);
            needleFigure.Segments.Add(new RadLineSegment() { Point = new Point(0.55, 0.5) });
            needleFigure.Segments.Add(new RadArcSegment()
            {
                Center = new Point(0.5, 0.5),
                Size = new Size(0.05, 0.05),
                StartAngle = 0,
                SweepAngle = 360
            });

            RadPathGeometry needleGeometry = new RadPathGeometry();
            needleGeometry.Figures.Add(needleFigure);

            gauge.Indicators.Add(new GaugeNeedleIndicator()
            {
                Value = 60,
                Fill = Color.FromHex("037AFF"),
                Stroke = Color.FromHex("037AFF"),
                StrokeThickness = 3,
                Position = GaugeElementPosition.Start,
                Offset = 35,
                Shape = needleGeometry
            });

            GaugeRangesDefinition gaugeRanges = new GaugeRangesDefinition()
            {
                StartThickness = 4,
                EndThickness = 4,
                Position = GaugeElementPosition.End
            };

            gaugeRanges.Ranges.Add(new GaugeRange() { From = 0, To = 60, Color = Color.FromHex("646464") });
            gaugeRanges.Ranges.Add(new GaugeRange() { From = 61, To = 120, Color = Color.FromHex("424242") });
            gaugeRanges.Ranges.Add(new GaugeRange() { From = 121, To = 180, Color = Color.FromHex("DD0000") });

            gauge.Ranges = gaugeRanges;

            Content = gauge;
        }
    }
}
