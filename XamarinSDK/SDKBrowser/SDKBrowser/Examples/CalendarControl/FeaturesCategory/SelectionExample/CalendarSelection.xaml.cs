using System;
using Telerik.XamarinForms.Input.Calendar;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.SelectionExample
{	
   [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarSelection : ContentView
    {
        public CalendarSelection()
        {
            InitializeComponent ();

            this.smPicker.ItemsSource = Enum.GetValues(typeof(CalendarSelectionMode));          
        }

        private void SelectionModeChanged(object sender, EventArgs e)
        {
            calendar.SelectionMode = (CalendarSelectionMode)smPicker.SelectedItem;
        }
    }
}
