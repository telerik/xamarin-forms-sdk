using System.ComponentModel;
using System.Runtime.CompilerServices;
using Telerik.XamarinForms.Common;

namespace SDKBrowser.Examples.DataGridControl.NestedPropertyCategory.NestedPropertyExample
{
    // >> datagrid-nested-property-person
    public class Person : NotifyPropertyChangedBase
    {
        private string name;
        private double age;
        private Address address;

        public string Name
        {
            get { return this.name; }
            set { this.UpdateValue(ref this.name, value); }
        }
        public double Age
        {
            get { return this.age; }
            set { this.UpdateValue(ref this.age, value); }
        }
        public Address Address
        {
            get { return this.address; }
            set { this.UpdateValue(ref this.address, value); }
        }
    }
    // << datagrid-nested-property-person
}

