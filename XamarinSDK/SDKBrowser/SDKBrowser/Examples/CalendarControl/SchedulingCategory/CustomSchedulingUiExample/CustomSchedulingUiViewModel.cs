using System;
using System.Collections.ObjectModel;
using SDKBrowser.Common;
using SDKBrowser.ViewModels;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.CustomSchedulingUiExample
{
    public class CustomSchedulingUiViewModel
    {
        public CustomSchedulingUiViewModel()
        {
            this.Appointments = AppointmentsGenerator.GenerateAppointments();
        }

        public ObservableCollection<CustomAppointment> Appointments { get; }

        public void NavigateToAddAppointmentPage()
        {
            var addAppointmentViewModel = new AddAppointmentViewModel(this.Appointments);
            var contentPage = new ContentPage() { Content = new AddAppointmentView() { BindingContext = addAppointmentViewModel } };
            NavigationPage.SetHasNavigationBar(contentPage, false);
            Application.Current.MainPage.Navigation.PushAsync(contentPage);
        }

        public void NavigateToAddAppointmentPage(DateTime startTime, DateTime endTime)
        {
            var addAppointmentViewModel = new AddAppointmentViewModel(this.Appointments, startTime, endTime);
            var contentPage = new ContentPage() { Content = new AddAppointmentView() { BindingContext = addAppointmentViewModel } };
            NavigationPage.SetHasNavigationBar(contentPage, false);
            Application.Current.MainPage.Navigation.PushAsync(contentPage);
        }

        public void NavigateToReadAppointmentPage(CustomAppointment appointment)
        {
            var readAppointmentViewModel = new ReadAppointmentViewModel(appointment, this.Appointments);
            var contentPage = new ContentPage() { Content = new ReadAppointmentView() { BindingContext = readAppointmentViewModel } };
            NavigationPage.SetHasNavigationBar(contentPage, false);
            Application.Current.MainPage.Navigation.PushAsync(contentPage);
        }
    }
}
