using System.Collections;
using System.Collections.Generic;
using Telerik.XamarinForms.Input.DataForm;

namespace SDKBrowser.Examples.DataForm.DataAnnotations.DataSourceKey
{
    // >> dataform-dataannotations-validation-locationprovider
    public class GenderValidatorAttribute : ValidatorBaseAttribute
    {
        public GenderValidatorAttribute()
        {
            this.ErrorMessage = "invalid gender";
        }

        protected override bool ValidateCore(object value)
        {
            return (Gender)value != Gender.Unspecified;
        }
    }
    // << dataform-dataannotations-validation-locationprovider
}

