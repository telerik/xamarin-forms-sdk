using Xamarin.Forms;
using Telerik.XamarinForms.Input;


namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.DataSourceKeyExample
{
    public class DataFormDataAnnotationsDataSourceKeyCSharp : ContentView
    {
        public DataFormDataAnnotationsDataSourceKeyCSharp()
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

