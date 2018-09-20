using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Common;

namespace SDKBrowser.Examples.DataGridControl.NestedPropertyCategory.NestedPropertyExample
{
    // >> datagrid-nested-proprty-address
    public class Address : NotifyPropertyChangedBase
    {
        private string city;
        private string street;
        public string City
        {
            get { return this.city; }
            set { this.UpdateValue(ref this.city, value); }
        }
        public string Street
        {
            get { return this.street; }
            set { this.UpdateValue(ref this.street, value); }
        }
    }
    // << datagrid-nested-proprty-address
}
