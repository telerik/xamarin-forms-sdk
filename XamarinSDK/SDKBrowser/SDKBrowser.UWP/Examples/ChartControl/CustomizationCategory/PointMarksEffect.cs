using Telerik.UI.Xaml.Controls.Chart;
using Windows.UI;
using Windows.UI.Xaml;
using Xamarin.Forms.Platform.UWP;

using EXAMPLE = SDKBrowser.Examples.ChartControl.CustomizationCategory.PointMarksExample;
using TXFC = Telerik.XamarinForms.Chart;
using XF = Xamarin.Forms;

[assembly: Xamarin.Forms.ExportEffect(typeof(SDKBrowser.UWP.Examples.ChartControl.CustomizationCategory.PointMarksExample.PointMarksEffect), EXAMPLE.PointMarksEffect.PointMarksEffectName)]

namespace SDKBrowser.UWP.Examples.ChartControl.CustomizationCategory.PointMarksExample
{
    public class PointMarksEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            this.UpdatePointMarkTemplates();

            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged += this.Series_CollectionChanged;
        }

        protected override void OnDetached()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged -= this.Series_CollectionChanged;
        }

        private void UpdatePointMarkTemplates()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            RadCartesianChart nativeChart = (RadCartesianChart)this.Control;

            for (int i = 0; i < nativeChart.Series.Count; i++)
            {
                LineSeries lineSeries = nativeChart.Series[i] as LineSeries;
                if (lineSeries != null)
                {
                    this.TrySetPointMarkTemplate(lineSeries, xfChart.Series[i]);
                }
            }
        }

        private void TrySetPointMarkTemplate(LineSeries nativeLineSeries, TXFC.CartesianSeries xfSeries)
        {
            XF.Color xfColor = EXAMPLE.PointMarksEffect.GetColor(xfSeries);
            if (xfColor == XF.Color.Default)
            {
                nativeLineSeries.PointTemplate = null;
                return;
            }

            Color color = ToWinColor(xfColor);

            string xamlString = @"
<DataTemplate xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Ellipse Width=""10"" Height=""10"" Fill=""" + color + @""" />
</DataTemplate>";

            nativeLineSeries.PointTemplate = (DataTemplate)Windows.UI.Xaml.Markup.XamlReader.Load(xamlString);
        }

        private Color ToWinColor(XF.Color xfColor)
        {
            return Color.FromArgb((byte)(xfColor.A * 255), (byte)(xfColor.R * 255), (byte)(xfColor.G * 255), (byte)(xfColor.B * 255));
        }

        private void Series_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.UpdatePointMarkTemplates();
        }
    }
}
