using System;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public partial class DataFormEditors : ContentPage
    {
        public DataFormEditors()
        {
            this.InitializeComponent();

            this.dataForm.RegisterEditor("Name", EditorType.TextEditor);
            this.dataForm.RegisterEditor("Genre", EditorType.PickerEditor);
            this.dataForm.RegisterEditor("TargetGroup", EditorType.SegmentedEditor);
            this.dataForm.RegisterEditor("Year", EditorType.NumberPickerEditor);
            this.dataForm.RegisterEditor("Rating", EditorType.SliderEditor);
            this.dataForm.RegisterEditor("IsPublished", EditorType.CheckBoxEditor);
            this.dataForm.RegisterEditor("IsDue", EditorType.ToggleButtonEditor);
            this.dataForm.RegisterEditor("LastReviewed", EditorType.DateEditor);
            this.dataForm.RegisterEditor("BorrowTime", EditorType.TimeEditor);
        }

        private async void DataFormValidationCompleted(object sender, FormValidationCompletedEventArgs e)
        {
            this.dataForm.FormValidationCompleted -= this.DataFormValidationCompleted;
            if (e.IsValid)
            {
                await this.DisplayAlert("Success", "Book was successfully updated.", "OK");
            }
            else
            {
                await this.DisplayAlert("Error", string.Format("There are some invalid fields."), "OK");
            }
        }

        private void CommitButtonButtonClicked(object sender, EventArgs e)
        {
            this.dataForm.FormValidationCompleted += this.DataFormValidationCompleted;
            this.dataForm.CommitAll();
        }
    }
}