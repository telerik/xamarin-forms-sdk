using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public partial class PlotBandAnnotationsPage
    {
        public PlotBandAnnotationsPage()
        {
            InitializeComponent();

            var model = new MainViewModel();
            var data = MainViewModel.GetCategoricalData();
            model.Data1 = data;

            var startTreshold = data.Average(c => c.Value) * 0.9;
            var endTreshold = data.Average(c => c.Value) * 1.1;


            var chart = new Telerik.XamarinForms.Chart.RadCartesianChart
            {
                HorizontalAxis = new Telerik.XamarinForms.Chart.CategoricalAxis()
                {
                    LabelFitMode = Telerik.XamarinForms.Chart.AxisLabelFitMode.MultiLine,
                    PlotMode = Telerik.XamarinForms.Chart.AxisPlotMode.OnTicks
                },
                VerticalAxis = new Telerik.XamarinForms.Chart.NumericalAxis(),
                HeightRequest = 400
            };


            var series = new Telerik.XamarinForms.Chart.AreaSeries();

            series.ItemsSource = model.Data1;

            series.ValueBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "Value"
            };

            series.CategoryBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "Category"
            };

            chart.Series.Add(series);

            var annotation = new CartesianPlotBandAnnotation()
            {
                Axis = chart.VerticalAxis,
                From = startTreshold,
                To = endTreshold,
                Stroke = Color.Green,
                Fill =Color.FromHex("2F66FF33"),
                StrokeThickness = 2
            };

            chart.Annotations.Add(annotation);

            this.Content = chart;
        }
    }
}
