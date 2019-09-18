using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.SourceCategory.DataClassExample
{
    // >> dataform-source-dataclass-class
    public class Customer
    {
        [DisplayOptions(Group = "Basic Info", PlaceholderText = "First name", Header = "First Name")]
        [NonEmptyValidator("Please fill the first name", "OK")]
        public string FirstName { get; set; }

        [DisplayOptions(Group = "Basic Info", PlaceholderText = "Last Name", Header = "Last Name")]
        [NonEmptyValidator("Please fill the last name", "OK")]
        public string LastName { get; set; }

        [DisplayOptions(Group = "Additional Info", Header = "Age")]
        [NumericalRangeValidator(0, 100)]
        public int Age { get; set; }
    }
    // << dataform-source-dataclass-class
}

