using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.CurrentTimeIndicatorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrentTimeIndicator : ContentView
    {
        public CurrentTimeIndicator()
        {
            InitializeComponent();
        }
        private void CalendarLoaded(object sender, EventArgs e)
        {
            var calendar = (RadCalendar)sender;
            calendar.TrySetViewMode(CalendarViewMode.MultiDay);
        }
    }
}