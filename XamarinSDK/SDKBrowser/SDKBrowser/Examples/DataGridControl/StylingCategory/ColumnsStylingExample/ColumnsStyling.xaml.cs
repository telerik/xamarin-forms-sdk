using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.StylingCategory.ColumnsStylingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColumnsStyling : ContentView
    {
        public ColumnsStyling ()
        {
            InitializeComponent ();

            var source = new ObservableCollection<Data>();
            source.Add(new Data("India", "New Delhi"));
            source.Add(new Data("South Africa", "Cape Town"));
            source.Add(new Data("Nigeria", "Abuja"));
            source.Add(new Data("Singapore", "Singapore"));

            this.BindingContext = source;
        }
	}
}