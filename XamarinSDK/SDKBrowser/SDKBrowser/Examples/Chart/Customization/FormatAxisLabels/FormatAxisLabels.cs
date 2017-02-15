using System;
using System.Collections.Generic;
using SDKBrowser.Examples.Chart.Customization.FormatAxisLabels;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Chart
{
    public class FormatAxisLabels : ContentPage
    {
        public FormatAxisLabels()
        {
            var chart = new RadCartesianChart
            {
                VerticalAxis = new NumericalAxis
                {
                    LabelFormat = "C",
                    MajorStep = 0.5,
                    Minimum = -1,
                    Maximum = 1
                },
                HorizontalAxis = new DateTimeContinuousAxis
                {
                    LabelFormatter = new DateLabelFormatter(),
                    LabelFitMode = AxisLabelFitMode.Rotate,
                    MajorStepUnit = TimeInterval.Day,
                }
            };

            var series = new LineSeries
            {
                ItemsSource = GetSource(),
                ValueBinding = new PropertyNameDataPointBinding("Value"),
                CategoryBinding = new PropertyNameDataPointBinding("Date")
            };

            chart.Series.Add(series);

            this.Content = chart;
        }

        private List<DataItem> GetSource()
        {
            var data = new List<DataItem>();
            var startDate = new DateTime(2000, 1, 1);

            for (int i = 0; i < 6; i++)
            {
                data.Add(new DataItem { Date = startDate.AddDays(i), Value = Math.Sin(i) });
            }

            return data;
        }
    }
}
