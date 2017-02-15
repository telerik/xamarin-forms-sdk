using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public partial class AreaSeriesPage
    {
        public AreaSeriesPage()
        {
            InitializeComponent();

            var grid = new CartesianChartGrid();

            var model = new MainViewModel();
            model.Data1 = MainViewModel.GetCategoricalData();
            model.Data2 = MainViewModel.GetCategoricalData();

            var chart = new Telerik.XamarinForms.Chart.RadCartesianChart
            {
                HorizontalAxis = new Telerik.XamarinForms.Chart.CategoricalAxis()
                {
                    LabelFitMode = Telerik.XamarinForms.Chart.AxisLabelFitMode.MultiLine,
                    PlotMode = Telerik.XamarinForms.Chart.AxisPlotMode.OnTicks
                },
                VerticalAxis = new Telerik.XamarinForms.Chart.NumericalAxis(),
                Grid = grid,
            };

            grid.MajorLinesVisibility = GridLineVisibility.Y;
            grid.MajorYLineDashArray = Device.OnPlatform(null, new double[] { 4, 2 }, new double[] { 4, 2 });


            grid.MajorLineColor = Color.FromHex("D3D3D3");
            grid.MajorLineThickness = Device.OnPlatform(0.5, 2, 2);

            var series = new Telerik.XamarinForms.Chart.AreaSeries();

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
