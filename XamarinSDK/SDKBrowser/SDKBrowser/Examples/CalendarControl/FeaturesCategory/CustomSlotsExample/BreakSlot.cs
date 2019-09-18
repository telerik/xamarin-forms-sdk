using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.CustomSlotsExample
{
    // >> calendar-specialslots-customslot
    public class BreakSlot : SpecialSlot
    {
        private string title;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (this.title != value)
                {
                    this.title = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
    // << calendar-specialslots-customslot
}