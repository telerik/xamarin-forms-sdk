using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataForm.DataAnnotations.DataSourceKey
{
    // >> dataform-dataannotations-datasourcekey-source
    public class LocationData
    {
        [DisplayOptions(Header = "Location")]
        [DataSourceKey("LocationsSource")]
        public string Location { get; set; }
    }
    // << dataform-dataannotations-datasourcekey-source
}

