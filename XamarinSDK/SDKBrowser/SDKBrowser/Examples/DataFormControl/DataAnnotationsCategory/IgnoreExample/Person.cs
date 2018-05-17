
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.IgnoreExample
{
    // >> dataform-dataannotations-ignore-source
    public class Person
    {
        [DisplayOptions(Header = "Name")]
        public string Name { get; set; } = "Peter";

        [DisplayOptions(Header = "Age")]
        public int Age { get; set; } = 30;

        [Ignore]
        public double Weight { get; set; }
    }
    // << dataform-dataannotations-ignore-source
}
