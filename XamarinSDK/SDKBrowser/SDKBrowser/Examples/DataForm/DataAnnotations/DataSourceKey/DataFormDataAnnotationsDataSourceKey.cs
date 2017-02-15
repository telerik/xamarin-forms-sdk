using SDKBrowser.Examples.DataForm.DataAnnotations.DataSourceKey;
using Xamarin.Forms;
using Telerik.XamarinForms.Input;


namespace SDKBrowser.Examples.DataForm
{
    public class DataFormDataAnnotationsDataSourceKey : ContentPage
    {
        public DataFormDataAnnotationsDataSourceKey()
        {
            // >> dataform-dataannotations-datasourcekey-form
            var dataForm = new RadDataForm
            {
                Source = new LocationData(),
                PropertyDataSourceProvider = new LocationProvider()
            };

            dataForm.RegisterEditor("Location", EditorType.PickerEditor);
            // << dataform-dataannotations-datasourcekey-form

            Content = dataForm;
        }
    }
}

