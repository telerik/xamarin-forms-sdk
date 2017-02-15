using System;
using Xamarin.Forms;
using SDKBrowser.Examples.DataForm.DataAnnotations.Validation;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataForm
{
    public partial class DataFormDataAnnotationsValidation : ContentPage
    {
        public DataFormDataAnnotationsValidation()
        {
            InitializeComponent();
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
                await this.DisplayAlert("Success!", "All fields are valid.", "OK");
            }
            else
            {
                await this.DisplayAlert("Validation errors", string.Format("There are some invalid fields."), "OK");
            }
        }

        private void ValidationClicked(object sender, EventArgs e)
        {
            dataForm.FormValidationCompleted += ValidationCompleted;
            dataForm.ValidateAll();
        }
    }
}
