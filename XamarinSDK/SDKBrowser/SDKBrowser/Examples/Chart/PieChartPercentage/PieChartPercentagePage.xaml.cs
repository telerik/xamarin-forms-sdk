using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.Chart
{
	public partial class PieChartPercentagePage : ContentPage
	{
		public PieChartPercentagePage()
		{
			InitializeComponent();

			var pointsTotalValue = this.GetPointsTotalValue();
			this.series.LabelFormatter = new PercentageLabelFormatter(pointsTotalValue);
		}

		private double GetPointsTotalValue()
		{
			double totalValue = 0;

			foreach (var point in PieChartPercentageViewModel.GetData())
			{
				totalValue += point.Value;
			}

			return totalValue;
		}
	}
}
