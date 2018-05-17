using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.ValidationExample
{
    // >> dataform-dataannotations-validation-source
    public enum Occupation { Unspecified, Unemployed, Employed }

    public class Person
    {
        // >> (hide)
        [DisplayOptions(Header = "Age")]
        // << (hide)
        [NumericalRangeValidator(10, 15, "Age must be 10 and 15 years!")]
        public int Age { get; set; }

        // >> (hide)
        [DisplayOptions(Header = "Occupation")]
        // << (hide)
        [OccupationValidator]
        public Occupation Occupation { get; set; } = Occupation.Unspecified;

        // >> (hide)
        [DisplayOptions(Header = "Name")]
        // << (hide)
        [NonEmptyValidator("Name is required!")]
        public string Name { get; set; }
    }
    // << dataform-dataannotations-validation-source
}

