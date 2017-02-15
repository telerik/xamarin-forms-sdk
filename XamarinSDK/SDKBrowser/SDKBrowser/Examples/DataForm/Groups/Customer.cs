using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataForm.Groups
{
    public class Customer
    {
        const string UserGroup = "User Info";
        const string CompanyGroup = "Company Info";

        [DisplayOptions(Group = UserGroup, Header = "First Name", Position = 0)]
        public string FirstName { get; set; }

        [DisplayOptions(Group = UserGroup, Header = "Last Name", Position = 1)]
        public string LastName { get; set; }

        [DisplayOptions(Group = UserGroup, Header = "Email", Position = 2)]
        public string Email { get; set; }

        [DisplayOptions(Group = CompanyGroup, Header = "Company Name", Position = 0)]
        public string Age { get; set; }

        [DisplayOptions(Group = CompanyGroup, Header = "Employees count", Position = 1)]
        public int EmployeesCount { get; set; }

        [DisplayOptions(Group = CompanyGroup, Header = "Country", Position = 2)]
        public string Country { get; set; }
    }
}
