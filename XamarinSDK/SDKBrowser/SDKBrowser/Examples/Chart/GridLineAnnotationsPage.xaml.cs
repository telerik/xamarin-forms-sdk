using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public partial class GridLineAnnotationsPage
    {
        public GridLineAnnotationsPage()
        {
            InitializeComponent();

            var model = new MainViewModel();
            var data = MainViewModel.GetCategoricalData();
            model.Data1 = data;

            var treshold = data.Average(c => c.Value);
            var startTreshold = treshold * 0.95;
            var endTreshold = treshold * 1.05;


            var chart = new Telerik.XamarinForms.Chart.RadCartesianChart
            {
                HorizontalAxis = new Telerik.XamarinForms.Chart.CategoricalAxis()
                {
                    LabelFitMode = Telerik.XamarinForms.Chart.AxisLabelFitMode.MultiLine,
                },
                VerticalAxis = new Telerik.XamarinForms.Chart.NumericalAxis(),
                HeightRequest = 400
            };


            var series = new Telerik.XamarinForms.Chart.BarSeries();

            series.ItemsSource = model.Data1;

            series.ValueBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Value"
            };

            series.CategoryBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Category"
            };

            chart.Series.Add(series);

            var lineAnnotation = new CartesianGridLineAnnotation()
            {
                Axis = chart.VerticalAxis,
                Value = treshold,
                Stroke = Color.FromHex("0E72F6"),
                StrokeThickness = Device.OnPlatform(0.5,2, 2),
				DashArray = new double[] { 4, 2 }
            };

            var bandAnnotation = new CartesianPlotBandAnnotation()
            {
                Axis = chart.VerticalAxis,
                From = startTreshold,
                To = endTreshold,
                Fill =  Color.FromHex("33A9A9A9"),
                StrokeThickness = 2,
                Stroke = Color.Transparent,
            };

            chart.Annotations.Add(lineAnnotation);
            chart.Annotations.Add(bandAnnotation);

            this.Content = chart;
        }
    }
}
