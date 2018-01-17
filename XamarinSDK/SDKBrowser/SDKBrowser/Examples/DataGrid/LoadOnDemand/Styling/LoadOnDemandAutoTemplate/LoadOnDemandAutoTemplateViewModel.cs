using SDKBrowser.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataGrid
{
    public class LoadOnDemandAutoTemplateViewModel : ViewModelBase
    {
        public LoadOnDemandAutoTemplateViewModel()
        {
            this.Items = new ObservableCollection<Person>();

            for (int i = 0; i < 20; i++)
            {
                var person = new Person { Name = "Person " + i, Age = i + 18, Gender = i % 2 == 0 ? Gender.Male : Gender.Female };
                this.Items.Add(person);
            }
        }
        
        public ObservableCollection<Person> Items { get; set; }
  
    }
}
