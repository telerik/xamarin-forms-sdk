using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.ValidateCategory
{
    // >> dataform-validate-source
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
    // << dataform-validate-source
}
