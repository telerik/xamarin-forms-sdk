using Telerik.XamarinForms.ChartRenderer.iOS;
using TelerikUI;
using UIKit;
using Xamarin.Forms.Platform.iOS;

using EXAMPLE = SDKBrowser.Examples.ChartControl.CustomizationCategory.GradientBarsExample;
using TXFC = Telerik.XamarinForms.Chart;
using XF = Xamarin.Forms;

[assembly: Xamarin.Forms.ResolutionGroupName(SDKBrowser.Common.Constants.TelerikName)]
[assembly: Xamarin.Forms.ExportEffect(typeof(SDKBrowser.iOS.Examples.ChartControl.CustomizationCategory.GradientBarsExample.GradientBarsEffect), EXAMPLE.GradientBarsEffect.GradientBarsEffectName)]

namespace SDKBrowser.iOS.Examples.ChartControl.CustomizationCategory.GradientBarsExample
{
    public class GradientBarsEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            this.UpdateGradientBarFills();

            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged += this.Series_CollectionChanged;
        }

        protected override void OnDetached()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged -= this.Series_CollectionChanged;
        }

        private static TKChartPalette CreatePalette(UIColor startColor, UIColor endColor)
        {
            TKChartPalette palette = new TKChartPalette();
            palette.AddPaletteItem(CreateItem(startColor, endColor));
            return palette;
        }

        private static TKFill CreateGradientBarFill(UIColor startColor, UIColor endColor)
        {
            return new TKLinearGradientFill(new Foundation.NSObject[] { startColor, endColor, }, new CoreGraphics.CGPoint(0.5, 1), new CoreGraphics.CGPoint(0.5, 0));
        }

        private static TKChartPaletteItem CreateItem(UIColor startColor, UIColor endColor)
        {
            return new TKChartPaletteItem(CreateGradientBarFill(startColor, endColor));
        }

        private void UpdateGradientBarFills()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            TKExtendedChart nativeChart = (TKExtendedChart)this.Control;

            for (int i = 0; i < nativeChart.Series.Length; i++)
            {
                TKChartColumnSeries columnSeries = nativeChart.Series[i] as TKChartColumnSeries;
                if (columnSeries != null)
                {
                    this.TrySetGradientBarFill(columnSeries, xfChart.Series[i]);
                }
            }
        }

        private void TrySetGradientBarFill(TKChartColumnSeries columnSeries, TXFC.CartesianSeries xfSeries)
        {
            XF.Color xfStartColor = EXAMPLE.GradientBarsEffect.GetStartColor(xfSeries);
            XF.Color xfEndColor = EXAMPLE.GradientBarsEffect.GetEndColor(xfSeries);
            if (xfStartColor == XF.Color.Default || xfEndColor == XF.Color.Default)
            {
                return;
            }

            columnSeries.Style.Palette = CreatePalette(ColorExtensions.ToUIColor(xfStartColor), ColorExtensions.ToUIColor(xfEndColor));
        }

        private void Series_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.UpdateGradientBarFills();
        }
    }
}
