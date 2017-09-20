using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;

namespace SDKBrowser.Examples.Chart
{
	public class PercentageLabelFormatter : LabelFormatterBase<double>
	{
		private double totalValue;

		public PercentageLabelFormatter(double totalValue)
		{
			this.totalValue = totalValue;
		}

		public override string FormatTypedValue(double value)
		{
			return string.Format("{0:P}", value / totalValue);
		}
	}
}
