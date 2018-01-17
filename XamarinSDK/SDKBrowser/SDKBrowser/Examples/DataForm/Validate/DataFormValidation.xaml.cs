using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public partial class DataFormValidation : ContentPage
    {
        public DataFormValidation()
        {
            InitializeComponent();

            this.BindingContext = new User();

            dataForm.RegisterEditor("Payment", EditorType.DecimalEditor);
            dataForm.RegisterEditor("BirthDate", EditorType.DateEditor);

            foreach (var validationMode in Enum.GetNames(typeof(ValidationMode)))
            {
                validationModePicker.Items.Add(validationMode);
            }

            validationModePicker.SelectedIndex = 0;
        }

        private async void DataFormValidationCompleted(object sender, FormValidationCompletedEventArgs e)
        {
            if (e.IsValid)
            {
                await this.DisplayAlert("Success!", "User was successfully updated.", "OK");
            }
            else
            {
                await this.DisplayAlert("Validation errors", string.Format("There are some invalid fields."), "OK");
            }
        }

        private void ValidationModeChanged(object sender, System.EventArgs e)
        {
            var validationMode = (ValidationMode)Enum.Parse(typeof(ValidationMode), validationModePicker.Items[validationModePicker.SelectedIndex]);
            dataForm.ValidationMode = validationMode;
        }

        private void ReloadFormClicked(object sender, System.EventArgs e)
        {
            dataForm.Source = new User();
        }

        private void CommitClicked(object sender, System.EventArgs e)
        {
            dataForm.CommitAll();
        }

        public class User : NotifyPropertyChangedBase
        {
            private string name;
            private double payment;
            private DateTime birthDate = new DateTime(1959, 1, 1);

            [DisplayOptions(Header = "Name")]
            [StringLengthValidator(2, int.MaxValue, "Your name should be longer than 2 symbols.", "ok")]
            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    if (this.name != value)
                    {
                        this.name = value;
                        this.OnPropertyChanged();
                    }
                }
            }

            [DisplayOptions(Header = "Payment amount (USD)")]
            [NumericalRangeValidator(100, 5000, "Only payments between $100 and $5000 are accepted.", "ok")]
            public double Payment
            {
                get
                {
                    return this.payment;
                }
                set
                {
                    if (this.payment != value)
                    {
                        this.payment = value;
                        this.OnPropertyChanged();
                    }
                }
            }

            [DisplayOptions(Header = "Birth Date")]
            [DateRangeValidator(1960, 1, 1, 1990, 12, 31, "You must be born between 1960 and 1990 year.", "ok")]
            [DisplayValueFormat(Date = "d")]
            public DateTime BirthDate
            {
                get
                {
                    return this.birthDate;
                }
                set
                {
                    if (this.birthDate != value)
                    {
                        this.birthDate = value;
                        this.OnPropertyChanged();
                    }
                }
            }
        }
    }
}
