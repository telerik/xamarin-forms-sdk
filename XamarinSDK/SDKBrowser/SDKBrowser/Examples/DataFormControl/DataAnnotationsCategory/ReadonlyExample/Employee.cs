using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.ReadonlyExample
{
    // >> dataform-dataannotations-readonly-source
    public class Employee
    {
        [DisplayOptions(Header = "FirstName")]
        public string FirstName { get; set; } = "John";

        [DisplayOptions(Header = "LastName")]
        public string LastName { get; set; } = "Doe";

        [DisplayOptions(Header = "Manager")]
        [ReadOnly]
        public string Manager { get; set; } = "Michael";
    }
    // << dataform-dataannotations-readonly-source
}

