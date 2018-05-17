using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChartControl.AnnotationsCategory.PlotBandAnnotationsExample
{
    public class PlotBandAnnotationsCSharp : ContentView
    {
        public PlotBandAnnotationsCSharp()
        {
            // >> chart-annotations-plotband-csharp
            var verticalAxis = new NumericalAxis();
            var chart = new RadCartesianChart
            {
                BindingContext = new ViewModel(),
                HorizontalAxis = new CategoricalAxis
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                    PlotMode = AxisPlotMode.OnTicks
                },
                VerticalAxis = verticalAxis,
                Series =
                {
                    new AreaSeries
                    {
                        ValueBinding = new PropertyNameDataPointBinding("Value"),
                        CategoryBinding = new PropertyNameDataPointBinding("Category")
                    }
                },
                Annotations =
                {
                    new CartesianPlotBandAnnotation()
                    {
                        Axis = verticalAxis,
                        StrokeThickness = 2,
                        Stroke = Color.Green,
                        Fill =  Color.FromHex("2F66FF33")
                    }
                }
            };

            chart.Series[0].SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            chart.Annotations[0].SetBinding(CartesianPlotBandAnnotation.FromProperty, "StartThreshold");
            chart.Annotations[0].SetBinding(CartesianPlotBandAnnotation.ToProperty, "EndThreshold");
            // << chart-annotations-plotband-csharp

            this.Content = chart;
        }
    }
}
