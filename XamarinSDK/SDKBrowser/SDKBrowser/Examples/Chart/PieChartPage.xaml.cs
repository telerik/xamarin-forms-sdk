using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public partial class PieChartPage
    {
        public PieChartPage()
        {
            InitializeComponent();

            var model = new MainViewModel();
            model.Data1 = MainViewModel.GetCategoricalData();

            var chart = new Telerik.XamarinForms.Chart.RadPieChart
            {
				HeightRequest = 400,
                
			};

            chart.BindingContext = model;

            var series = new Telerik.XamarinForms.Chart.PieSeries();
            series.RadiusFactor = 0.8;
            series.ShowLabels = true;

            series.ValueBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Value"
            };
					
            series.SetBinding(PieSeries.ItemsSourceProperty, new Binding("Data1"));
            chart.Series.Add(series);

            this.Content = chart;
        }
    }
}
