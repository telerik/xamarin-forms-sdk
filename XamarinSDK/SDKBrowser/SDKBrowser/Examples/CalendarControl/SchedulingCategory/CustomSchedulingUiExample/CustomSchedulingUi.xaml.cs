using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.CustomSchedulingUiExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomSchedulingUi : ContentView
    {
        public CustomSchedulingUi()
        {
            InitializeComponent();

            View addAppointmentButton = null;

            if (Device.RuntimePlatform == Device.Android)
            {
                addAppointmentButton = this.CreateAndroidAddAppointmentButton();
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                addAppointmentButton = this.CreateiOSAddAppointmentButton();
            }
            else
            {
                addAppointmentButton = this.CreateUWPAddAppointmentButton();
            }

            this.root.Children.Add(addAppointmentButton);

            this.BindingContext = new CustomSchedulingUiViewModel();
        }

        public void AppointmentTapped(object sender, Telerik.XamarinForms.Input.AppointmentTappedEventArgs e)
        {
            ((CustomSchedulingUiViewModel)this.BindingContext).NavigateToReadAppointmentPage((CustomAppointment)e.Appointment);
        }

        public void TimeSlotTapped(object sender, Telerik.XamarinForms.Input.TimeSlotTapEventArgs e)
        {
            ((CustomSchedulingUiViewModel)this.BindingContext).NavigateToAddAppointmentPage(e.StartTime, e.EndTime);
        }

        private View CreateAndroidAddAppointmentButton()
        {
            var border = new RadBorder
            {
                WidthRequest = 56,
                HeightRequest = 56,
                BackgroundColor = Color.FromHex("#3F74D3"),
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
                Margin = new Thickness(0, 0, 16, 50),
                CornerRadius = 28
            };

            border.GestureRecognizers.Add(new TapGestureRecognizer()

            {
                Command = new Command(() =>
                ((CustomSchedulingUiViewModel)this.BindingContext).NavigateToAddAppointmentPage())
            });

            var label = new Label
            {
                Text = "+",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 20
            };

            border.Content = label;

            return border;
        }

        private View CreateiOSAddAppointmentButton()
        {
            var label = new Label
            {
                Text = "+",
                TextColor = Color.FromHex("#007AFF"),
                FontSize = 30,
                HorizontalOptions = LayoutOptions.End,
                Margin = new Thickness(0, -5, 10, 0),
            };

            label.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                ((CustomSchedulingUiViewModel)this.BindingContext).NavigateToAddAppointmentPage())
            });

            return label;
        }

        private View CreateUWPAddAppointmentButton()
        {
            var grid = new Grid
            {
                VerticalOptions = LayoutOptions.End,
                BackgroundColor = Color.FromHex("#EBEBEB"),
                HeightRequest = 50
            };

            var label = new Label
            {
                Text = "+",
                TextColor = Color.FromHex("#3148CA"),
                FontSize = 35,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 0, 30, 0),
            };

            grid.Children.Add(label);

            label.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                ((CustomSchedulingUiViewModel)this.BindingContext).NavigateToAddAppointmentPage())
            });

            return grid;
        }
    }
}
