using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataFormControl.ValidateCategory.CommitModeExample
{
    public partial class DataFormCommitMode : ContentView
    {
        public DataFormCommitMode()
        {
            this.InitializeComponent();

            this.BindingContext = new User();

            dataForm.RegisterEditor("Payment", EditorType.DecimalEditor);
            dataForm.RegisterEditor("BirthDate", EditorType.DateEditor);
        }

        void CommitButtonClicked(object sender, EventArgs e)
        {
            // >> dataform-commit-method
            dataForm.CommitProperty("Name");
            // << dataform-commit-method
        }
    }
}

