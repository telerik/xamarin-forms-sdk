using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public partial class PanZoomPage
    {
        RadCartesianChart chart;
        public PanZoomPage()
        {
            this.Appearing += PanZoomPage_Appearing;
            InitializeComponent();

            var model = new MainViewModel();
            model.Data1 = MainViewModel.GetCategoricalData2();
            model.Data2 = MainViewModel.GetDateTimeData2(200);

            this.chart = new Telerik.XamarinForms.Chart.RadCartesianChart
            {
                VerticalAxis = new Telerik.XamarinForms.Chart.NumericalAxis(),
                HorizontalAxis = new Telerik.XamarinForms.Chart.DateTimeContinuousAxis()
                {
                    LabelFitMode = Telerik.XamarinForms.Chart.AxisLabelFitMode.Rotate,
                    MajorStepUnit = Telerik.XamarinForms.Chart.TimeInterval.Day,
                    PlotMode = Telerik.XamarinForms.Chart.AxisPlotMode.OnTicks,
                    LabelFormat = "dd MMM",
                    MajorStep = 20,
                    ShowLabels = true
                },
                HeightRequest = 400,
            };

            var series = new Telerik.XamarinForms.Chart.LineSeries();

            series.DisplayName = "Sales";
            series.ItemsSource = model.Data2;

            series.ValueBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Value",
            };

            series.CategoryBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Date",
            };

            series.AllowSelect = true;

            chart.Series.Add(series);
            chart.PaletteName = Telerik.XamarinForms.Chart.PaletteNames.Light;
            chart.Behaviors.Add(new Telerik.XamarinForms.Chart.ChartPanAndZoomBehavior
            {
            });

            this.Content = chart;
        }

        void PanZoomPage_Appearing(object sender, EventArgs e)
        {
            this.chart.Zoom = new Size(2, 1);
        }
    }
}
