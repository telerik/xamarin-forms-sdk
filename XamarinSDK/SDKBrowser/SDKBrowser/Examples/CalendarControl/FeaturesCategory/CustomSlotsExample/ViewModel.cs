using System;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.CustomSlotsExample
{
    // >> calendar-customslots-vm
    public class ViewModel
    {
        public ViewModel()
        {
            this.RestHours = new ObservableCollection<BreakSlot>();

            var today = DateTime.Today;
            var dailyRecurrence = new RecurrencePattern()
            {
                DaysOfWeekMask = RecurrenceDays.WeekDays,
                Frequency = RecurrenceFrequency.Weekly,
                MaxOccurrences = 30
            };

            this.RestHours.Add(new BreakSlot()
            {
                Title = "Lunch time",
                StartDate = today.AddHours(12),
                EndDate = today.AddHours(13),
                IsReadOnly = true,
                RecurrencePattern = dailyRecurrence
            });
            this.RestHours.Add(new BreakSlot()
            {
                Title = "Coffee break",
                StartDate = today.AddHours(16),
                EndDate = today.AddHours(16).AddMinutes(30),
                RecurrencePattern = dailyRecurrence
            });
        }

        public ObservableCollection<BreakSlot> RestHours { get; set; }
    }
    // << calendar-customslots-vm
}
