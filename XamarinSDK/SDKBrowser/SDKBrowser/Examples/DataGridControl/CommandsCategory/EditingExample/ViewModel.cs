using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKBrowser.Examples.DataGridControl.CommandsCategory.EditingExample
{
    // >> datagrid-commands-editing-viewmodel
    public class ViewModel
    {
        public ObservableCollection<Data> Items { get; set; }

        public ViewModel()
        {
            this.Items = new ObservableCollection<Data>()
            {
                new Data { Country = "India", Capital = "New Delhi"},
                new Data { Country = "South Africa", Capital = "Cape Town"},
                new Data { Country = "Nigeria", Capital = "Abuja" },
                new Data { Country = "Singapore", Capital = "Singapore" }
            };
        }
    }
    // << datagrid-commands-editing-viewmodel
}
