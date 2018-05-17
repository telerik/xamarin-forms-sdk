using System.Collections;
using System.Collections.Generic;
using Telerik.XamarinForms.Input.DataForm;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.DataSourceKeyExample
{
    // >> dataform-dataannotations-datasourcekey-locationprovider
    public class LocationProvider : PropertyDataSourceProvider
    {
        public override IList GetSourceForKey(object key)
        {
            if (key.ToString() == "LocationsSource")
            {
                return new List<string> { "Top", "Bottom", "Left", "Right" };
            }

            return null;
        }
    }
    // << dataform-dataannotations-datasourcekey-locationprovider
}

