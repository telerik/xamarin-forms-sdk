using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.InteractivityCategory.ToolTipSeriesExample
{
    public class ToolTipSeriesCSharp : ContentView
    {
        public ToolTipSeriesCSharp()
        {
            // >> chart-interactivity-tooltipseries-csharp
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
                HorizontalAxis = new CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                    PlotMode = AxisPlotMode.OnTicks
                },
                VerticalAxis = new NumericalAxis(),
                Series =
                {
                    new LineSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category"),
                        DisplayName = "Sales 1"
                    },
                },
                ChartBehaviors =
                {
                    new ChartTooltipBehavior
                    {
                        TriggerMode = ToolTipTriggerMode.Tap
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            // << chart-interactivity-tooltipseries-csharp

            this.Content = chart;
        }
    }
}
