using System.Collections;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.Input.DataForm;

namespace SDKBrowser.Examples.DataFormControl.PropertyDataSourceProviderCategory.ObservableCollectionSourceExample
{
    // >> dataform-propertydatasource-locationprovider
    public class LocationProvider : PropertyDataSourceProvider
    {
        public ObservableCollection<string> Cities = new ObservableCollection<string>();
        public ObservableCollection<string> Countries = new ObservableCollection<string>();
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
    // << dataform-propertydatasource-locationprovider
}
