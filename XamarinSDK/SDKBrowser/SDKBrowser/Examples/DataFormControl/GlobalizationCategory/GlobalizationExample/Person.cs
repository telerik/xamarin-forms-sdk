using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.GlobalizationCategory.GlobalizationExample
{
    // >> dataform-globalization-display-options-keys
    public class Person
    {
        [DisplayOptions(HeaderResourceKey = "Age",
                        PlaceholderTextResourceKey = "AgePlaceholder",
                        GroupResourceKey = "PrivateInfo")]
        public int? Age { get; set; }

        [DisplayOptions(HeaderResourceKey = "Weight",
                        PlaceholderTextResourceKey = "WeightPlaceholder",
                        GroupResourceKey = "PrivateInfo")]
        public int? Weight { get; set; }

        [DisplayOptions(HeaderResourceKey = "FirstName",
                        PlaceholderTextResourceKey = "FirstNamePlaceholder",
                        GroupResourceKey = "PublicInfo")]
        public string FirstName { get; set; }

        [DisplayOptions(HeaderResourceKey = "LastName",
                        PlaceholderTextResourceKey = "LastNamePlaceholder",
                        GroupResourceKey = "PublicInfo")]
        public string LastName { get; set; }

        [DisplayOptions(Header = "Town",
                        PlaceholderText = "Not localized...",
                        Group = "PublicInfo")]
        public string HomeTown { get; set; }
    }
    // << dataform-globalization-display-options-keys
}
