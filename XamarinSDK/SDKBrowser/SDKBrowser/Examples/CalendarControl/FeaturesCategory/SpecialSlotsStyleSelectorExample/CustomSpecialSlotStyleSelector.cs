using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.SpecialSlotsStyleSelectorExample
{
    // >> calendar-specialslots-customselector
    public class RestHoursStyleSelector : SpecialSlotStyleSelector
    {
        public CalendarSpecialSlotStyle LunchBreakStyle { get; set; }
        public CalendarSpecialSlotStyle ShortBreakStyle { get; set; }

        public override CalendarSpecialSlotStyle SelectStyle(object item)
        {
            var specialSlot = item as SpecialSlot;
            if (specialSlot.StartDate.Hour == 12)
                return this.LunchBreakStyle;
            
            return this.ShortBreakStyle;
        }
    }
    // << calendar-specialslots-customselector
}
