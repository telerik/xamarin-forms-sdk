using System.Collections;
using System.Collections.Generic;
using Telerik.XamarinForms.Input.DataForm;

namespace SDKBrowser.Examples.DataFormControl.PropertyDataSourceProviderCategory.UpdatePropertyDataSourceExample
{
    // >> dataform-updatepropertydatasource-locationprovider
    public class LocationProvider : PropertyDataSourceProvider
    {
        public List<string> Cities = new List<string>();
        public List<string> Countries;

        public override IList GetSourceForKey(object key)
        {
            string keyString = key as string;

            if (keyString == nameof(Customer.Country))
            {
                return this.Countries;
            }
            else if (keyString == nameof(Customer.City))
            {
                return this.Cities;
            }
            else
            {
                return base.GetSourceForKey(key);
            }
        }
    }
    // << dataform-updatepropertydatasource-locationprovider
}
