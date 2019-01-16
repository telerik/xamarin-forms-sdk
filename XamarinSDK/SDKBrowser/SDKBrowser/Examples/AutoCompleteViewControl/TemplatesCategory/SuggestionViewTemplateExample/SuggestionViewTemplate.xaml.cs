using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.TemplatesCategory.SuggestionViewTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuggestionViewTemplate : ContentView
    {
        public SuggestionViewTemplate ()
        {
            InitializeComponent ();
            this.BindingContext = new ViewModel();
        }

        private void DataGrid_SelectionChanged(object sender, Telerik.XamarinForms.DataGrid.DataGridSelectionChangedEventArgs e)
        {
            this.autoCompleteView.HideSuggestions();

            var item = e.AddedItems.FirstOrDefault() as Person;
            if (item != null)
            {
                this.autoCompleteView.Tokens.Add(item);
                this.autoCompleteView.Text = string.Empty;
                
            }
        }
    }
}