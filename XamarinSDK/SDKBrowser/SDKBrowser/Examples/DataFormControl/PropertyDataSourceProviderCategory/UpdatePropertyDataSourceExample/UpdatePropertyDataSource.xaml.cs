using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataFormControl.PropertyDataSourceProviderCategory.UpdatePropertyDataSourceExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdatePropertyDataSource : ContentView
    {
        private LocationProvider locationProvider = new LocationProvider();
        public UpdatePropertyDataSource()
        {
            InitializeComponent();

            // >> dataform-propertydatasource-method-setup
            dataForm.Source = new Customer();

            dataForm.RegisterEditor(nameof(Customer.Country), EditorType.PickerEditor);
            dataForm.RegisterEditor(nameof(Customer.City), EditorType.PickerEditor);

            this.locationProvider = new LocationProvider();
            this.locationProvider.Countries = new List<string>() { "Germany", "Argentina", "USA" };
            this.UpdateCities(locationProvider.Countries[0]);

            dataForm.PropertyDataSourceProvider = locationProvider;            
            // << dataform-propertydatasource-method-setup            
        }

        // >> dataform-updatepropertydatasource-event
        private void DataForm_EditorValueChanged(object sender, Telerik.XamarinForms.Input.DataForm.EditorValueChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Customer.Country))
            {
                this.UpdateCities((string)e.NewValue);
                dataForm.UpdatePropertyDataSource(nameof(Customer.City));
            }
        }

        private void UpdateCities(string country)
        {
            this.locationProvider.Cities = new List<string>();

            if (country == "Germany")
            {
                this.locationProvider.Cities.Add("Berlin");
                this.locationProvider.Cities.Add("Frankfurt am Main");
                this.locationProvider.Cities.Add("Hamburg");
            }
            else if (country == "Argentina")
            {
                this.locationProvider.Cities.Add("Buenos Aires");
                this.locationProvider.Cities.Add("Cordoba");
            }
            else
            {
                this.locationProvider.Cities.Add("Miami");
                this.locationProvider.Cities.Add("New York");
                this.locationProvider.Cities.Add("Los Angeles");
            }
        }
        // << dataform-updatepropertydatasource-event
    }
}