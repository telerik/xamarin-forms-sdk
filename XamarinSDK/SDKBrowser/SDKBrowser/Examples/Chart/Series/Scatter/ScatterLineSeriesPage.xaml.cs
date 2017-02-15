using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public partial class ScatterLineSeriesPage
    {
        public ScatterLineSeriesPage()
        {
            InitializeComponent();

            var model = new MainViewModel();
            model.Data1 = MainViewModel.GetNumericData2(20, 30, 3, (i) => 60 * i + 450, (i) => 20 * (Math.Sin(0.13 * i)) + 6);
            model.Data2 = MainViewModel.GetNumericData2(20, 30, 5, (i) => 60 * i + 450, (i) => 20 * (Math.Sin(0.13 * i)) + 6, true);

            var grid = new CartesianChartGrid();

            var chart = new Telerik.XamarinForms.Chart.RadCartesianChart
            {
                VerticalAxis = new Telerik.XamarinForms.Chart.NumericalAxis(),
                HorizontalAxis = new Telerik.XamarinForms.Chart.NumericalAxis()
                {
                    LabelFitMode = Telerik.XamarinForms.Chart.AxisLabelFitMode.MultiLine,
                },
                Grid = grid,
            };


            grid.MajorLinesVisibility = GridLineVisibility.XY;
            grid.MajorYLineDashArray = Device.OnPlatform(null, new double[] { 4, 2 }, new double[] { 4, 2 });
            grid.MajorXLineDashArray = Device.OnPlatform(null, new double[] { 4, 2 }, new double[] { 4, 2 });


            grid.MajorLineColor = Color.FromHex("D3D3D3");
            grid.MajorLineThickness = Device.OnPlatform(0.5, 2, 2);


            var series = new Telerik.XamarinForms.Chart.ScatterLineSeries();

            series.ItemsSource = model.Data1;

            series.XValueBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "XData"
            };

            series.YValueBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "YData"
            };

            chart.Series.Add(series);

            var series1 = new Telerik.XamarinForms.Chart.ScatterLineSeries();

            series1.ItemsSource = model.Data2;

            series1.XValueBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "XData"
            };

            series1.YValueBinding = new PropertyNameDataPointBinding
            {
                PropertyName = "YData"
            };

            chart.Series.Add(series1);

            this.Content = chart;
        }
    }
}
