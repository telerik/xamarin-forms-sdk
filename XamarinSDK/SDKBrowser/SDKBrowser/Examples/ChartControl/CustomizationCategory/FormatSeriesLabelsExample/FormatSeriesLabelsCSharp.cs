using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.FormatSeriesLabelsExample
{
    public class FormatSeriesLabelsCSharp : ContentView
    {
        public FormatSeriesLabelsCSharp()
        {
            // >> chart-customization-formatserieslabels-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
                VerticalAxis = new NumericalAxis
                {
                    Minimum = -1.5,
                    Maximum = 1.5
                },
                HorizontalAxis = new DateTimeContinuousAxis
                {
                    LabelFitMode = AxisLabelFitMode.Rotate,
                    MajorStepUnit = TimeInterval.Day,
                },
                Series =
                {
                    new LineSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Date"),
                        ShowLabels = true,
                        LabelFormat = "{0:N2}"
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-customization-formatserieslabels-csharp

            this.Content = chart;
        }
    }
}
