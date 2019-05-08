using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.HowToCategory.EmailPasswordEditorsExample
{
    // >> dataform-howto-emailpasswordeditors-source
    public class Account
    {
        [DisplayOptions(Header = "Username", PlaceholderText = "user name", Group = "Registration Info")]
        [StringLengthValidator(5, 30, "Username should be longer than 5 symbols.")]
        public string UserName { get; set; }

        [DisplayOptions(Header = "Email", PlaceholderText = "email", Group = "Registration Info")]
        public string Email { get; set; }

        [DisplayOptions(Header = "Password", PlaceholderText = "password", Position = 2, Group = "Registration Info")]
        [StringLengthValidator(5, 30, "Password should be longed than 5 symbols.")]
        public string Password { get; set; }
    }
    // << dataform-howto-emailpasswordeditors-source
}
