using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public partial class BarSeriesPage
    {
        public BarSeriesPage()
        {
            InitializeComponent();

            var model = new MainViewModel();
            model.Data1 = MainViewModel.GetCategoricalData();
            model.Data2 = MainViewModel.GetCategoricalData();

            var grid = new CartesianChartGrid();

            var chart = new Telerik.XamarinForms.Chart.RadCartesianChart
            {
                VerticalAxis = new Telerik.XamarinForms.Chart.NumericalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                },
                HorizontalAxis = new Telerik.XamarinForms.Chart.CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                },
                Grid = grid,
            };

            grid.MajorLinesVisibility = GridLineVisibility.Y;
            grid.MajorYLineDashArray = Device.OnPlatform(null, new double[] { 4, 2 }, new double[] { 4, 2 });
            grid.StripLinesVisibility = GridLineVisibility.Y;

            grid.YStripeColor = Color.Transparent;

            grid.YStripeAlternativeColor = Color.FromHex("1FA9A9A9");
            grid.MajorLineColor = Color.FromHex("D3D3D3");
            grid.MajorLineThickness = Device.OnPlatform(0.5, 2, 2);

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


            //series.Stroke = Color.Gray;
            //series.StrokeThickness = 4;

            chart.Series.Add(series);

            this.Content = chart;
        }
    }
}
