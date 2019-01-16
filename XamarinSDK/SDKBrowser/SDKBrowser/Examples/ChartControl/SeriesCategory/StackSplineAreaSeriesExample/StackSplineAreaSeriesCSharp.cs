using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.SeriesCategory.StackSplineAreaSeriesExample
{
    public class StackSplineAreaSeriesCSharp : ContentView
    {
        public StackSplineAreaSeriesCSharp()
        {
            // >> chart-series-stacksplinearea-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new SeriesCategoricalViewModel(),
                HorizontalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                    PlotMode = AxisPlotMode.OnTicks
                },
                VerticalAxis = new NumericalAxis(),
                Series =
                {
                    new SplineAreaSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        CombineMode = ChartSeriesCombineMode.Stack
                    },
                    new SplineAreaSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        CombineMode = ChartSeriesCombineMode.Stack
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data1");
            chart.Series[1].SetBinding(ChartSeries.ItemsSourceProperty, "Data2");
            // << chart-series-stacksplinearea-csharp

            this.Content = chart;
        }
    }
}
