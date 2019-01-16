using Com.Telerik.Widget.Chart.Visualization.CartesianChart;
using Com.Telerik.Widget.Chart.Visualization.CartesianChart.Series.Categorical;
using Xamarin.Forms.Platform.Android;

using EXAMPLE = SDKBrowser.Examples.ChartControl.CustomizationCategory.PointMarksExample;
using TXFC = Telerik.XamarinForms.Chart;
using XF = Xamarin.Forms;

//[assembly: Xamarin.Forms.ResolutionGroupName(SDKBrowser.Common.Constants.TelerikName)]
[assembly: Xamarin.Forms.ExportEffect(typeof(SDKBrowser.Droid.Examples.ChartControl.CustomizationCategory.PointMarksExample.PointMarksEffect), EXAMPLE.PointMarksEffect.PointMarksEffectName)]

namespace SDKBrowser.Droid.Examples.ChartControl.CustomizationCategory.PointMarksExample
{
    public class PointMarksEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            this.UpdatePointMarkRenderers();

            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged += this.Series_CollectionChanged;
        }

        protected override void OnDetached()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged -= this.Series_CollectionChanged;
        }

        private void UpdatePointMarkRenderers()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            RadCartesianChartView nativeChart = (RadCartesianChartView)this.Control;

            for (int i = 0; i < nativeChart.Series.Size(); i++)
            {
                LineSeries lineSeries = nativeChart.Series.Get(i) as LineSeries;
                if (lineSeries != null)
                {
                    this.TrySetPointMarkRenderer(lineSeries, xfChart.Series[i]);
                }
            }
        }

        private void TrySetPointMarkRenderer(LineSeries lineSeries, TXFC.CartesianSeries xfSeries)
        {
            XF.Color xfColor = EXAMPLE.PointMarksEffect.GetColor(xfSeries);
            if (xfColor == XF.Color.Default)
            {
                return;
            }

            lineSeries.DataPointRenderer = new PointMarkRenderer(ColorExtensions.ToAndroid(xfColor));
        }

        private void Series_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.UpdatePointMarkRenderers();
        }
    }
}
