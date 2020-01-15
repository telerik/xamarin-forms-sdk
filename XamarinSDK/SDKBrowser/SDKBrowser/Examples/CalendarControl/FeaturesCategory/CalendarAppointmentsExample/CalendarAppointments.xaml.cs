using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.CalendarAppointmentsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarAppointments : ContentView
    {
        public CalendarAppointments()
        {
            InitializeComponent();

            this.segmentControl.ItemsSource = new List<string>() { "Day", "Month" };
        }

        private void SelectedIndex_Chanded(object sender, Telerik.XamarinForms.Common.ValueChangedEventArgs<int> e)
        {
            if (e.NewValue == 0)
            {
                calendar.ViewMode = CalendarViewMode.Day;
            }
            else
            {
                calendar.ViewMode = CalendarViewMode.Month;
            }
        }
    }
}