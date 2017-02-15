using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public partial class ScatterAreaSeriesPage
    {
        public ScatterAreaSeriesPage()
        {
            InitializeComponent();

            var model = new MainViewModel();
            model.Data1 = MainViewModel.GetNumericData2(20, 30, 3, (i) => 60 * i + 450, (i) => 20 * (Math.Sin(0.13 * i)) + 6);
            
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

            grid.MajorLinesVisibility = GridLineVisibility.Y;
            grid.MajorYLineDashArray = Device.OnPlatform(null, new double[] { 4, 2 }, new double[] { 4, 2 });


            grid.MajorLineColor = Color.FromHex("D3D3D3");
            grid.MajorLineThickness = Device.OnPlatform(0.5, 2, 2);


            var series = new Telerik.XamarinForms.Chart.ScatterAreaSeries();

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

            this.Content = chart;
        }
    }
}
