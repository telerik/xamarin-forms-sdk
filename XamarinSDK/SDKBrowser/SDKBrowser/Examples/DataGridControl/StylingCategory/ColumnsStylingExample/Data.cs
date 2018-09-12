using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKBrowser.Examples.DataGridControl.StylingCategory.ColumnsStylingExample
{
    public class Data
    {
        public Data(string country, string capital)
        {
            this.Country = country;
            this.Capital = capital;
        }
        public string Country { get; set; }
        public string Capital { get; set; }
    }
}
