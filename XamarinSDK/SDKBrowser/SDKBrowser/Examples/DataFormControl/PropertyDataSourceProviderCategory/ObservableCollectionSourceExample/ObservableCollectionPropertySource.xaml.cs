using System.Collections.ObjectModel;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataFormControl.PropertyDataSourceProviderCategory.ObservableCollectionSourceExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObservableCollectionPropertySource : ContentView
    {
        private LocationProvider locationProvider = new LocationProvider();
        public ObservableCollectionPropertySource()
        {
            InitializeComponent();

            // >> dataform-propertydatasource-setup
            dataForm.Source = new Customer();

            dataForm.RegisterEditor(nameof(Customer.Country), EditorType.PickerEditor);
            dataForm.RegisterEditor(nameof(Customer.City), EditorType.PickerEditor);

            this.locationProvider = new LocationProvider();
            this.locationProvider.Countries = new ObservableCollection<string>()
            { "Germany", "Argentina", "USA"};
            this.UpdateCities(locationProvider.Countries[0]);

            dataForm.PropertyDataSourceProvider = locationProvider;

            // << dataform-propertydatasource-setup          
        }

        // >> dataform-propertydatasource-updatecities
        private void DataForm_EditorValueChanged(object sender, Telerik.XamarinForms.Input.DataForm.EditorValueChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Customer.Country))
            {
               this.UpdateCities((string)e.NewValue);
            }
        }

        private void UpdateCities(string country)
        {
            this.locationProvider.Cities.Clear();

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
        // << dataform-propertydatasource-updatecities
    }
}