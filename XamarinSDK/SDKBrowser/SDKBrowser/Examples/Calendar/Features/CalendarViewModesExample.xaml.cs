using System;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Calendar
{
    public partial class CalendarViewModesExample : ContentPage
    {
        public CalendarViewModesExample()
        {
            InitializeComponent();

            calendar.DisplayDate = new DateTime(2017, 4, 12);

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
