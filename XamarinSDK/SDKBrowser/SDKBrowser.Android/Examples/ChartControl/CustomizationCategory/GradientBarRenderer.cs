using Android.Graphics;
using Com.Telerik.Android.Common.Math;
using Com.Telerik.Widget.Chart.Engine.DataPoints;
using Com.Telerik.Widget.Chart.Visualization.CartesianChart.Series.Pointrenderers;

namespace SDKBrowser.Droid.Examples.ChartControl.CustomizationCategory.GradientBarsExample
{
    internal class GradientBarRenderer : Java.Lang.Object, IChartDataPointRenderer
    {
        private Color startColor;
        private Color endColor;

        public GradientBarRenderer(Color startColor, Color endColor)
        {
            this.startColor = startColor;
            this.endColor = endColor;
        }

        public void RenderPoint(Canvas canvas, DataPoint dataPoint)
        {
            RadRect slot = dataPoint.LayoutSlot;
            Paint paint = this.CreatePaint(dataPoint);
            canvas.DrawRect((float)slot.GetX(), (float)slot.GetY(), (float)slot.Right, (float)slot.Bottom, paint);
            paint.Dispose();
        }

        private Paint CreatePaint(DataPoint dataPoint)
        {
            Paint paint = new Paint();
            paint.SetShader(new LinearGradient(0, (float)dataPoint.LayoutSlot.Bottom, 0, (float)dataPoint.LayoutSlot.GetY(), this.startColor, this.endColor, Shader.TileMode.Mirror));
            return paint;
        }
    }
}
