using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.FormatAxisLabelsExample
{
    public class FormatAxisLabelsCSharp : ContentView
    {
        public FormatAxisLabelsCSharp()
        {
            // >> chart-customization-formataxislabels-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
                VerticalAxis = new NumericalAxis
                {
                    LabelFormat = "C",
                    MajorStep = 0.5,
                    Minimum = -1,
                    Maximum = 1
                },
                HorizontalAxis = new DateTimeContinuousAxis
                {
                    LabelFormatter = new DateLabelFormatter(),
                    LabelFitMode = AxisLabelFitMode.Rotate,
                    MajorStepUnit = TimeInterval.Day,
                },
                Series =
                {
                    new LineSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Date")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-customization-formataxislabels-csharp

            this.Content = chart;
        }
    }
}
