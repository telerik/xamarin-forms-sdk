using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataForm.Styling.Groups
{
    // >> dataform-styling-groups-dataitem
    public class Customer
    {
        [DisplayOptions(Group = "Basic Info", Header = "First Name")]
        public string FirstName { get; set; } = "John";

        [DisplayOptions(Group = "Basic Info", Header = "Last Name")]
        public string LastName { get; set; } = "Doe";

        [DisplayOptions(Group = "Additional Info", Header = "Age")]
        public int Age { get; set; } = 24;

        [DisplayOptions(Group = "Additional Info", Header = "Is New")]
        public bool IsNew { get; set; } = true;

        [DisplayOptions(Group = "Additional Info", Header = "Country")]
        public string Country { get; set; } = "unknown";
    }
    // << dataform-styling-groups-dataitem
}
