using System;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.ValidateCategory.ValidationExample
{
    public partial class DataFormValidation : ContentView
    {
        public DataFormValidation()
        {
            this.InitializeComponent();

            // >> dataform-validate-code
            this.BindingContext = new User();

            dataForm.RegisterEditor("Payment", EditorType.DecimalEditor);
            dataForm.RegisterEditor("BirthDate", EditorType.DateEditor);
            // << dataform-validate-code
        }

        // >> dataform-validate-event-code
        private async void DataFormValidationCompleted(object sender, FormValidationCompletedEventArgs e)
        {
            if (e.IsValid)
            {
                await Application.Current.MainPage.DisplayAlert("Success!", "User was successfully updated.", "OK");
            }          
        }
        // << dataform-validate-event-code

        private void ReloadFormClicked(object sender, System.EventArgs e)
        {
            dataForm.Source = new User();
        }

        private void ValidateClicked(object sender, System.EventArgs e)
        {
            // >> dataform-validate-method
            dataForm.ValidateAll();
            // << dataform-validate-method
        }
    }
}
