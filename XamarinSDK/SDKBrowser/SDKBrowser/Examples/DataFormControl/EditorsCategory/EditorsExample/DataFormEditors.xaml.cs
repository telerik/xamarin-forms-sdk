using System;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.EditorsCategory.EditorsExample
{
    public partial class DataFormEditors : ContentView
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
                await Application.Current.MainPage.DisplayAlert("Success", "Book was successfully updated.", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "There are some invalid fields.", "OK");
            }
        }

        private void CommitButtonButtonClicked(object sender, EventArgs e)
        {
            this.dataForm.FormValidationCompleted += this.DataFormValidationCompleted;
            this.dataForm.CommitAll();
        }
    }
}