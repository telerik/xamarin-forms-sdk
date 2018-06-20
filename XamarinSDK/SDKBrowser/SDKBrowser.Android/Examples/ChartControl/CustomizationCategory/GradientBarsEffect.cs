using Com.Telerik.Widget.Chart.Visualization.CartesianChart;
using Com.Telerik.Widget.Chart.Visualization.CartesianChart.Series.Categorical;
using Xamarin.Forms.Platform.Android;

using EXAMPLE = SDKBrowser.Examples.ChartControl.CustomizationCategory.GradientBarsExample;
using TXFC = Telerik.XamarinForms.Chart;
using XF = Xamarin.Forms;

[assembly: Xamarin.Forms.ResolutionGroupName(SDKBrowser.Common.Constants.TelerikName)]
[assembly: Xamarin.Forms.ExportEffect(typeof(SDKBrowser.Droid.Examples.ChartControl.CustomizationCategory.GradientBarsExample.GradientBarsEffect), EXAMPLE.GradientBarsEffect.GradientBarsEffectName)]

namespace SDKBrowser.Droid.Examples.ChartControl.CustomizationCategory.GradientBarsExample
{
    public class GradientBarsEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            this.UpdateGradientBarRenderers();

            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged += this.Series_CollectionChanged;
        }

        protected override void OnDetached()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged -= this.Series_CollectionChanged;
        }

        private void UpdateGradientBarRenderers()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            RadCartesianChartView nativeChart = (RadCartesianChartView)this.Control;

            for (int i = 0; i < nativeChart.Series.Size(); i++)
            {
                BarSeries barSeries = nativeChart.Series.Get(i) as BarSeries;
                if (barSeries != null)
                {
                    this.TrySetGradientBarRenderer(barSeries, xfChart.Series[i]);
                }
            }
        }

        private void TrySetGradientBarRenderer(BarSeries barSeries, TXFC.CartesianSeries xfSeries)
        {
            XF.Color xfStartColor = EXAMPLE.GradientBarsEffect.GetStartColor(xfSeries);
            XF.Color xfEndColor = EXAMPLE.GradientBarsEffect.GetEndColor(xfSeries);
            if (xfStartColor == XF.Color.Default || xfEndColor == XF.Color.Default)
            {
                return;
            }

            barSeries.DataPointRenderer = new GradientBarRenderer(ColorExtensions.ToAndroid(xfStartColor), ColorExtensions.ToAndroid(xfEndColor));
        }

        private void Series_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.UpdateGradientBarRenderers();
        }
    }
}
