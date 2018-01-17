using System;
using System.Collections;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.Common.Data;

namespace SDKBrowser.Examples.DataGrid.Filtering
{
    public class LocalizationViewModel
    {
        public LocalizationViewModel()
        {
            var source = new ObservableCollection<MyCity>();
            source.Add(new MyCity("Vratsa", 54150));
            source.Add(new MyCity("Mexico City", 22000000));
            source.Add(new MyCity("Trieste", 204849));
            source.Add(new MyCity("Ottawa", 934243));
            source.Add(new MyCity("Caracas", 1943901));
            source.Add(new MyCity("Amsterdam", 851573));
            source.Add(new MyCity("Pittsburgh", 305704));
            source.Add(new MyCity("Athens", 664046));
            source.Add(new MyCity("Taipei", 2704974));
            source.Add(new MyCity("Marseille", 855393));
            source.Add(new MyCity("Pnom Penh", 1501725));

            this.GridSource = source;
        }

        public ObservableCollection<MyCity> GridSource { get; set; }
     
    }
}
