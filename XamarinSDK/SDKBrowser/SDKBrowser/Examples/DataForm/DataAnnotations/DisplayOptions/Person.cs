using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataForm.DataAnnotations.DisplayOptions
{
    // >> dataform-dataannotations-displayoptions-source
    public class Person
    {
        [DisplayOptions(Header = "FirstName", PlaceholderText = "first name", Group = "Public Info")]
        public string FirstName { get; set; } = "Peter";

        [DisplayOptions(Header = "LastName", PlaceholderText = "last name", Group = "Public Info")]
        public string LastName { get; set; } = "Pan";

        [DisplayOptions(Header = "Age", PlaceholderText = "age", Group = "Private Info")]
        public int Age { get; set; } = 13;

        [DisplayOptions(Header = "Weight", PlaceholderText = "weight", Group = "Private Info")]
        public double Weight { get; set; } = 48;
    }
    // << dataform-dataannotations-displayoptions-source
}

