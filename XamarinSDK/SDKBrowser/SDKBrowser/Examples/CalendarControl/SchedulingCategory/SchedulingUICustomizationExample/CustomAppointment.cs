using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.SchedulingUICustomizationExample
{
    // >> schedulingui-custom-appointment-model
    public class CustomAppointment : Appointment
    {
        private string owner;
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value != this.owner)
                {
                    this.owner = value;
                    this.OnPropertyChanged();
                }
            }
        }
        public override Appointment Copy()
        {
            CustomAppointment newApp = new CustomAppointment();
            newApp.CopyFrom(this);
            return newApp;
        }

        public override void CopyFrom(Appointment other)
        {
            if (other is CustomAppointment customAppointment)
            {
                this.Owner = customAppointment.Owner;
            }

            base.CopyFrom(other);
        }
    }
    // << schedulingui-custom-appointment-model
}
