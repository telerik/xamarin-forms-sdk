using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.PropertyDataSourceProviderCategory.UpdatePropertyDataSourceExample
{
    // >> dataform-updatepropertydatasource-customer
    public class Customer
    {
        [DisplayOptions(Header = "Name", Position = 0)]
        public string Name { get; set; }

        [DisplayOptions(Header = "Email", Position = 1)]
        public string Email { get; set; }

        [DisplayOptions(Header = "Country", Position = 2)]
        public string Country { get; set; }

        [DisplayOptions(Header = "City", Position = 3)]
        public string City { get; set; }
    }
    // << dataform-updatepropertydatasource-customer
}
