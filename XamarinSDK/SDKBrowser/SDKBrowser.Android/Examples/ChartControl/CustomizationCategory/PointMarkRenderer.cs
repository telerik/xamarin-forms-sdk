using Android.Graphics;
using Com.Telerik.Android.Common.Math;
using Com.Telerik.Widget.Chart.Engine.DataPoints;
using Com.Telerik.Widget.Chart.Visualization.CartesianChart.Series.Pointrenderers;

namespace SDKBrowser.Droid.Examples.ChartControl.CustomizationCategory.PointMarksExample
{
    internal class PointMarkRenderer : Java.Lang.Object, IChartDataPointRenderer
    {
        private Color color;

        public PointMarkRenderer(Color color)
        {
            this.color = color;
        }

        public void RenderPoint(Canvas canvas, DataPoint dataPoint)
        {
            RadRect slot = dataPoint.LayoutSlot;
            using (Paint paint = this.CreatePaint(dataPoint))
            {
                canvas.DrawCircle((float)slot.Center.GetX(), (float)slot.Center.GetY(), 10, paint);
            }
        }

        private Paint CreatePaint(DataPoint dataPoint)
        {
            Paint paint = new Paint();
            paint.Color = this.color;
            return paint;
        }
    }
}
