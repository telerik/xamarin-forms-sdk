using System;
using Xamarin.Forms;
using SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.ValidationExample;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.ValidationExample
{
    public partial class DataFormDataAnnotationsValidation : ContentView
    {
        public DataFormDataAnnotationsValidation()
        {
            this.InitializeComponent();
            // >> dataform-dataannotations-validation-form
            dataForm.Source = new Person();
            dataForm.RegisterEditor("Occupation", EditorType.SegmentedEditor);
            // << dataform-dataannotations-validation-form
        }

        async void ValidationCompleted(object sender, Telerik.XamarinForms.Input.DataForm.FormValidationCompletedEventArgs e)
        {
            dataForm.FormValidationCompleted -= ValidationCompleted;
            if (e.IsValid)
            {
                await Application.Current.MainPage.DisplayAlert("Success!", "All fields are valid.", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Validation errors", string.Format("There are some invalid fields."), "OK");
            }
        }

        private void ValidationClicked(object sender, EventArgs e)
        {
            dataForm.FormValidationCompleted += ValidationCompleted;
            dataForm.ValidateAll();
        }
    }
}
