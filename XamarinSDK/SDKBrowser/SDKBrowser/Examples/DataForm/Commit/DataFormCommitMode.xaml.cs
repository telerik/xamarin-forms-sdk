using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public partial class DataFormCommitMode : ContentPage
    {
        public DataFormCommitMode()
        {
            InitializeComponent();

            this.BindingContext = new Item { Name = "Apples", Price = 25 };

            dataForm.RegisterEditor("Price", EditorType.DecimalEditor);

            foreach (var commitMode in Enum.GetNames(typeof(CommitMode)))
            {
                commitModePicker.Items.Add(commitMode);
            }

            commitModePicker.SelectedIndexChanged += (sender, e) =>
            {
                var commitMode = (CommitMode)Enum.Parse(typeof(CommitMode), commitModePicker.Items[commitModePicker.SelectedIndex]);

                commitButton.IsVisible = commitMode == CommitMode.Manual;
                dataForm.CommitMode = commitMode;
            };

            commitModePicker.SelectedIndex = 0;
        }

        void CommitButtonClicked(object sender, EventArgs e)
        {
            this.dataForm.FormValidationCompleted += this.DataFormValidationCompleted;
            dataForm.CommitAll();
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
                await this.DisplayAlert("Fail", string.Format("There are some invalid fields."), "OK");
            }
        }

        public class Item : NotifyPropertyChangedBase
        {
            private string name;
            private double price;

            [DisplayOptions(Header = "Name")]
            [StringLengthValidator(2, int.MaxValue, "Name should be longer than 2 symbols.", null)]
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

            [DisplayOptions(Header = "Price")]
            [NumericalRangeValidator(0, double.MaxValue, "Price should be positive.", null)]
            public double Price
            {
                get
                {
                    return this.price;
                }
                set
                {
                    if (this.price != value)
                    {
                        this.price = value;
                        this.OnPropertyChanged();
                    }
                }
            }
        }
    }
}

