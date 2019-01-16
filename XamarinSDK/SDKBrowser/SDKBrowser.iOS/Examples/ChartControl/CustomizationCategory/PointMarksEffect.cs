using CoreGraphics;
using Telerik.XamarinForms.ChartRenderer.iOS;
using TelerikUI;
using UIKit;
using Xamarin.Forms.Platform.iOS;

using EXAMPLE = SDKBrowser.Examples.ChartControl.CustomizationCategory.PointMarksExample;
using TXFC = Telerik.XamarinForms.Chart;
using XF = Xamarin.Forms;

[assembly: Xamarin.Forms.ExportEffect(typeof(SDKBrowser.iOS.Examples.ChartControl.CustomizationCategory.PointMarksExample.PointMarksEffect), EXAMPLE.PointMarksEffect.PointMarksEffectName)]

namespace SDKBrowser.iOS.Examples.ChartControl.CustomizationCategory.PointMarksExample
{
    public class PointMarksEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            this.UpdatePointMarkFills();

            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged += this.Series_CollectionChanged;
        }

        protected override void OnDetached()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged -= this.Series_CollectionChanged;
        }

        private static TKChartPalette CreatePalette(UIColor color)
        {
            TKChartPalette palette = new TKChartPalette();
            palette.AddPaletteItem(CreateItem(color));
            return palette;
        }

        private static TKFill CreatePointMarkFill(UIColor color)
        {
            return new TKSolidFill(color);
        }

        private static TKChartPaletteItem CreateItem(UIColor color)
        {
            return new TKChartPaletteItem(CreatePointMarkFill(color));
        }

        private void UpdatePointMarkFills()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            TKExtendedChart nativeChart = (TKExtendedChart)this.Control;

            for (int i = 0; i < nativeChart.Series.Length; i++)
            {
                TKChartLineSeries lineSeries = nativeChart.Series[i] as TKChartLineSeries;
                if (lineSeries != null)
                {
                    this.TrySetPointMarkFill(lineSeries, xfChart.Series[i]);
                }
            }
        }

        private void TrySetPointMarkFill(TKChartLineSeries lineSeries, TXFC.CartesianSeries xfSeries)
        {
            XF.Color xfColor = EXAMPLE.PointMarksEffect.GetColor(xfSeries);
            if (xfColor == XF.Color.Default)
            {
                return;
            }

            lineSeries.Style.ShapeMode = TKChartSeriesStyleShapeMode.AlwaysShow;
            lineSeries.Style.PointShape = new TKPredefinedShape(TKShapeType.Circle, new CGSize(10, 10));
            lineSeries.Style.Palette = CreatePalette(ColorExtensions.ToUIColor(xfColor));
            lineSeries.Style.ShapePalette = lineSeries.Style.Palette;
        }

        private void Series_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.UpdatePointMarkFills();
        }
    }
}
