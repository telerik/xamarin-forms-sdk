using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.StylingCategory.StyleSelectorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StyleSelector : ContentView
    {
        public StyleSelector ()
        {
            InitializeComponent ();
            // >> datagrid-styleselector-items
            var source = new ObservableCollection<Data>();
            source.Add(new Data("India", "New Delhi"));
            source.Add(new Data("South Africa", "Cape Town"));
            source.Add(new Data("Nigeria", "Abuja"));
            source.Add(new Data("Singapore", "Singapore"));
            source.Add(new Data("Romania", "Bucharest"));
            source.Add(new Data("Spain", "Madrid"));
            source.Add(new Data("France", "Paris"));
            source.Add(new Data("Japan", "Tokyo"));

            datagrid.ItemsSource = source;
            // << datagrid-styleselector-items
        }
    }
}