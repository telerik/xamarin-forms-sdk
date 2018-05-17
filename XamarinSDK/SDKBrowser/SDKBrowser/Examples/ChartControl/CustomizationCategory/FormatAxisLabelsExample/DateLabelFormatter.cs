using System;
using Telerik.XamarinForms.Chart;

namespace SDKBrowser.Examples.ChartControl.CustomizationCategory.FormatAxisLabelsExample
{
    // >> chart-customization-format-axis-labels-label-formatter
    public class DateLabelFormatter : LabelFormatterBase<DateTime>
    {
        public override string FormatTypedValue(DateTime value)
        {
            if (value.Day == 1)
            {
                return value.Day + "st";
            }
            else if (value.Day == 2)
            {
                return value.Day + "nd";
            }
            else if (value.Day == 3)
            {
                return value.Day + "rd";
            }
            else
            {
                return value.Day + "th";
            }
        }
    }
    // << chart-customization-format-axis-labels-label-formatter
}
