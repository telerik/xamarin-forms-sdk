using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public partial class StackBarHorizontal
    {
        public StackBarHorizontal()
        {
            InitializeComponent();

            var model = new MainViewModel();
            model.Data1 = MainViewModel.GetCategoricalData();
            model.Data2 = MainViewModel.GetCategoricalData();

            var grid = new CartesianChartGrid();

            var chart = new Telerik.XamarinForms.Chart.RadCartesianChart
            {
                HorizontalAxis = new Telerik.XamarinForms.Chart.NumericalAxis(),
                VerticalAxis = new Telerik.XamarinForms.Chart.CategoricalAxis(),
                Grid = grid,
            };

            grid.MajorLinesVisibility = GridLineVisibility.X;
            grid.MajorXLineDashArray = Device.OnPlatform(null, new double[] { 4, 2 }, new double[] { 4, 2 });
            grid.StripLinesVisibility = GridLineVisibility.X;

            grid.XStripeColor = Color.Transparent;

            grid.XStripeAlternativeColor = Color.FromHex("1FA9A9A9");
            grid.MajorLineColor = Color.FromHex("D3D3D3");
            grid.MajorLineThickness = Device.OnPlatform(0.5, 2, 2);


            var series = new Telerik.XamarinForms.Chart.BarSeries();

            series.CombineMode = Telerik.XamarinForms.Chart.ChartSeriesCombineMode.Stack;
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

            var series2 = new Telerik.XamarinForms.Chart.BarSeries();

            series2.CombineMode = Telerik.XamarinForms.Chart.ChartSeriesCombineMode.Stack;
            series2.ItemsSource = model.Data2;

            series2.ValueBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Value"
            };

            series2.CategoryBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Category"
            };

            chart.Series.Add(series2);

            this.Content = chart;
        }
    }
}
