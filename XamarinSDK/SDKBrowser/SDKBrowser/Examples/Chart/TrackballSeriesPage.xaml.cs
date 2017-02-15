using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
	public partial class TrackballSeriesPage
    {
		public TrackballSeriesPage()
        {
            InitializeComponent();

            var model = new MainViewModel();
            model.Data1 = MainViewModel.GetCategoricalData();
            model.Data2 = MainViewModel.GetCategoricalData2();

            var grid = new CartesianChartGrid();

            var chart = new Telerik.XamarinForms.Chart.RadCartesianChart
            {
                VerticalAxis = new Telerik.XamarinForms.Chart.NumericalAxis(),
                HorizontalAxis = new Telerik.XamarinForms.Chart.CategoricalAxis()
                {
                    LabelFitMode = Telerik.XamarinForms.Chart.AxisLabelFitMode.MultiLine,
                    PlotMode = Telerik.XamarinForms.Chart.AxisPlotMode.OnTicks
                },
                Grid = grid,
            };

            grid.MajorLinesVisibility = GridLineVisibility.XY;
            grid.MajorYLineDashArray = Device.OnPlatform(null, new double[] { 4, 2 }, new double[] { 4, 2 });
            grid.MajorXLineDashArray = Device.OnPlatform(null, new double[] { 4, 2 }, new double[] { 4, 2 });


            grid.MajorLineColor = Color.FromHex("D3D3D3");
            grid.MajorLineThickness = Device.OnPlatform(0.5, 2, 2);


            var series = new Telerik.XamarinForms.Chart.LineSeries();

            series.DisplayName = "Sales 1";
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

            var series1 = new Telerik.XamarinForms.Chart.LineSeries();

            series1.DisplayName = "Sales 2";
            series1.ItemsSource = model.Data2;

            series1.ValueBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Value"
            };

            series1.CategoryBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Category"
            };

            chart.Series.Add(series1);

			chart.Behaviors.Add(new Telerik.XamarinForms.Chart.ChartTrackBallBehavior
            {
                ShowIntersectionPoints = true,
                ShowTrackInfo = true
            });

            this.Content = chart;
        }
    }
}
