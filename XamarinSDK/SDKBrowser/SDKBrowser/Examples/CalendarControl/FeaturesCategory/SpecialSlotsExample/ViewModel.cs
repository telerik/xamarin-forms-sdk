using System;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.SpecialSlotsExample
{
    // >> calendar-specialslots-viewmodel
    public class ViewModel
    {
        public ViewModel()
        {
            this.RestHours = new ObservableCollection<SpecialSlot>();

            var today = DateTime.Today;
            var dailyRecurrence = new RecurrencePattern()
            {
                DaysOfWeekMask = RecurrenceDays.WeekDays,
                Frequency = RecurrenceFrequency.Weekly,
                MaxOccurrences = 30
            };

            this.RestHours.Add(new SpecialSlot(today.AddHours(12), today.AddHours(13))
            {
                RecurrencePattern = dailyRecurrence,
                IsReadOnly = true
            });
            this.RestHours.Add(new SpecialSlot(today.AddHours(16), today.AddHours(16).AddMinutes(15))
            {
                RecurrencePattern = dailyRecurrence
            });
        }

        public ObservableCollection<SpecialSlot> RestHours { get; set; }
    }
    // << calendar-specialslots-viewmodel
}
