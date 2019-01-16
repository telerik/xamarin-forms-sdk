using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.FinancialIndicatorsExample
{
    public class FinancialIndicatorsExampleCSharp : ContentView
    {
        public FinancialIndicatorsExampleCSharp()
        {
            // >> chart-series-financial-indicators-csharp
            var chart = new RadCartesianChart
            {
                BackgroundColor = Color.White,
                BindingContext = new ViewModel(),
                HorizontalAxis = new DateTimeContinuousAxis()
                {
                    LabelFitMode = AxisLabelFitMode.Rotate,
                    PlotMode = AxisPlotMode.BetweenTicks,
                    MajorStepUnit = TimeInterval.Day,
                    MajorStep = 2,
                    LabelFormat = "dd/MM",
                    LineColor = Color.FromHex("#A9A9A9")
                },
                VerticalAxis = new NumericalAxis()
                {
                    LineColor = Color.FromHex("#A9A9A9"),
                    Maximum = 350,
                    Minimum = 320,
                    MajorTickBackgroundColor = Color.FromHex("#A9A9A9")
                },
                Series =
                {
                    new OhlcSeries
                    {
                       CategoryBinding = new PropertyNameDataPointBinding("Category"),
                       OpenBinding = new PropertyNameDataPointBinding("Open"),
                       HighBinding = new PropertyNameDataPointBinding("High"),
                       LowBinding = new PropertyNameDataPointBinding("Low"),
                       CloseBinding = new PropertyNameDataPointBinding("Close")
                    },
                    new ExponentialMovingAverageIndicator
                    {
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        ValueBinding = new PropertyNameDataPointBinding("Close"),
                        Period = 7,
                        Stroke = Color.DarkGreen,
                        StrokeThickness = 1,
                        DisplayName = "EMA 7days"
                    },
                    new ExponentialMovingAverageIndicator
                    {
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        ValueBinding = new PropertyNameDataPointBinding("Close"),
                        Period = 14,
                        Stroke = Color.DarkOrange,
                        StrokeThickness = 1,
                        DisplayName = "EMA 14days"
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "SeriesData");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "SeriesData");
            chart.Series[2].SetBinding(ChartSeries.ItemsSourceProperty, "SeriesData");
            // << chart-series-financial-indicators-csharp
            this.Content = chart;
        }
    }
}