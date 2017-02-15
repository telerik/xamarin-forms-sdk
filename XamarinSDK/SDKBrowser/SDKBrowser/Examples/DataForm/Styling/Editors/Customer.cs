using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataForm.Styling.Editors
{
    public class Customer
    {
        [DisplayOptions(PlaceholderText = "First name", Header = "First Name", Position = 0)]
        [NonEmptyValidator("Please fill the first name")]
        public string FirstName { get; set; }

        [DisplayOptions(PlaceholderText = "Last Name", Header = "Last Name", Position = 1)]
        [NonEmptyValidator("Please fill the last name")]
        public string LastName { get; set; }

        [DisplayOptions(Header = "Age", Position = 2)]
        public int Age { get; set; } = 28;
    }
}
