using System;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.KeyFeaturesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeyFeatures : ContentView
    {
        public KeyFeatures()
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