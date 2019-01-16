using System;
using System.Collections.Generic;
using System.Windows.Input;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.CustomSchedulingUiExample
{
	public class ReadAppointmentViewModel : NotifyPropertyChangedBase
    {
        private ICollection<CustomAppointment> appointments;

        public ReadAppointmentViewModel(CustomAppointment appointment, ICollection<CustomAppointment> appointments)
        {
            this.Appointment = appointment;
            this.appointments = appointments;
            this.CancelCommand = new Command(this.GoBack);
            this.EditCommand = new Command(this.Edit);
            this.DeleteCommand = new Command(this.Delete);
        }

        public CustomAppointment Appointment { get; set; }

        public ICommand CancelCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        private void GoBack()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }

        private void Edit()
        {
            var editAppointmentViewModel = new EditAppointmentViewModel(this.Appointment, this.appointments);
            var contentPage = new ContentPage() { Content = new EditAppointmentView() { BindingContext = editAppointmentViewModel } };
            NavigationPage.SetHasNavigationBar(contentPage, false);
            Application.Current.MainPage.Navigation.PushAsync(contentPage);
        }

        private void Delete()
        {
            this.appointments.Remove(this.Appointment);
            this.GoBack();
        }
    }
}
