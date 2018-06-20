using Telerik.UI.Xaml.Controls.Chart;
using Windows.UI;
using Windows.UI.Xaml;
using Xamarin.Forms.Platform.UWP;

using EXAMPLE = SDKBrowser.Examples.ChartControl.CustomizationCategory.GradientBarsExample;
using TXFC = Telerik.XamarinForms.Chart;
using XF = Xamarin.Forms;

[assembly: Xamarin.Forms.ResolutionGroupName(SDKBrowser.Common.Constants.TelerikName)]
[assembly: Xamarin.Forms.ExportEffect(typeof(SDKBrowser.UWP.Examples.ChartControl.CustomizationCategory.GradientBarsExample.GradientBarsEffect), EXAMPLE.GradientBarsEffect.GradientBarsEffectName)]

namespace SDKBrowser.UWP.Examples.ChartControl.CustomizationCategory.GradientBarsExample
{
    public class GradientBarsEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            this.UpdateGradientBarTemplates();

            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged += this.Series_CollectionChanged;
        }

        protected override void OnDetached()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            xfChart.Series.CollectionChanged -= this.Series_CollectionChanged;
        }

        private void UpdateGradientBarTemplates()
        {
            TXFC.RadCartesianChart xfChart = (TXFC.RadCartesianChart)this.Element;
            RadCartesianChart nativeChart = (RadCartesianChart)this.Control;

            for (int i = 0; i < nativeChart.Series.Count; i++)
            {
                BarSeries barSeries = nativeChart.Series[i] as BarSeries;
                if (barSeries != null)
                {
                    this.TrySetGradientBarTemplate(barSeries, xfChart.Series[i]);
                }
            }
        }

        private void TrySetGradientBarTemplate(BarSeries nativeBarSeries, TXFC.CartesianSeries xfSeries)
        {
            XF.Color xfStartColor = EXAMPLE.GradientBarsEffect.GetStartColor(xfSeries);
            XF.Color xfEndColor = EXAMPLE.GradientBarsEffect.GetEndColor(xfSeries);
            if (xfStartColor == XF.Color.Default || xfEndColor == XF.Color.Default)
            {
                return;
            }

            Color startColor = ToWinColor(xfStartColor);
            Color endColor = ToWinColor(xfEndColor);

            string xamlString = @"
<DataTemplate xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Border>
        <Border.Background>
            <LinearGradientBrush StartPoint=""0.5, 1"" EndPoint=""0.5, 0"">
                <GradientStop Offset=""0"" Color=""" + startColor + @""" />
                <GradientStop Offset=""1"" Color=""" + endColor + @""" />
            </LinearGradientBrush>
        </Border.Background>
    </Border>
</DataTemplate>";

            nativeBarSeries.PointTemplate = (DataTemplate)Windows.UI.Xaml.Markup.XamlReader.Load(xamlString);
        }

        private Color ToWinColor(XF.Color xfColor)
        {
            return Color.FromArgb((byte)(xfColor.A * 255), (byte)(xfColor.R * 255), (byte)(xfColor.G * 255), (byte)(xfColor.B * 255));
        }

        private void Series_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.UpdateGradientBarTemplates();
        }
    }
}
