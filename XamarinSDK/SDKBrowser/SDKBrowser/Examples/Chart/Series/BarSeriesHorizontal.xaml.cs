using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public partial class BarSeriesHorizontal
    {
        public BarSeriesHorizontal()
        {
            InitializeComponent();

            var model = new MainViewModel();
            model.Data1 = MainViewModel.GetCategoricalData();
            model.Data2 = MainViewModel.GetCategoricalData();

            var grid = new CartesianChartGrid();

            var chart = new Telerik.XamarinForms.Chart.RadCartesianChart
            {
                VerticalAxis = new Telerik.XamarinForms.Chart.CategoricalAxis(),
                HorizontalAxis = new Telerik.XamarinForms.Chart.NumericalAxis(),
                HeightRequest = 400,
                Grid = grid,
            };

            grid.MajorLinesVisibility = GridLineVisibility.XY;
            grid.MajorXLineDashArray = Device.OnPlatform(null, new double[] { 4, 2 }, new double[] { 4, 2 });
            grid.StripLinesVisibility = GridLineVisibility.X;

            grid.XStripeAlternativeColor = Color.FromHex("FFA9A9A9");
            grid.MajorLineColor = Color.Green;
            grid.MajorLineThickness = Device.OnPlatform(0.5, 2, 2);


            grid.MajorLinesVisibility = GridLineVisibility.XY;

            //grid.MajorYLineDashArray = new double[] { 10, 10 };
            //grid.MajorXLineDashArray = new double[] { 5, 15 };
            grid.StripLinesVisibility = GridLineVisibility.None;
            //grid.XStripeColor = Color.FromRgba(255, 0, 0, 50);
            //grid.XStripeAlternativeColor = Color.FromRgba(0, 255, 0, 50);

            //grid.YStripeColor = Color.FromRgba(255, 0, 0, 50);
            //grid.YStripeAlternativeColor = Color.FromRgba(0, 255, 0, 50);
            grid.MajorLineColor = Color.Gray;
            grid.MajorLineThickness = 0.5;

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


            this.Content = chart;
        }
    }
}
