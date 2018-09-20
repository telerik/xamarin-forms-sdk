using System;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.CalendarViewModesExample
{
    public partial class CalendarViewModes : ContentView
    {
        public CalendarViewModes()
        {
            this.InitializeComponent();

            calendar.DisplayDate = new DateTime(2017, 12, 12, 0, 25, 0);

            viewModePicker.ItemsSource = Enum.GetValues(typeof(CalendarViewMode));
            viewModePicker.SelectedItem = CalendarViewMode.Day;
            viewModePicker.SelectedIndexChanged += ViewModeChanged;
        }

        private void ViewModeChanged(object sender, EventArgs e)
        {
            calendar.TrySetViewMode((CalendarViewMode)viewModePicker.SelectedItem);
        }

        private void CalendarLoaded(object sender, System.EventArgs e)
        {
            calendar.TrySetViewMode((CalendarViewMode)viewModePicker.SelectedItem);
        }
    }
}
