using SDKBrowser.Examples.ListView.CellTypes.TemplateSelectors;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListView
{
    public partial class ListViewItemTemplateSelectorXaml : ContentPage
    {
        public ListViewItemTemplateSelectorXaml()
        {
            InitializeComponent();
            this.listView.SelectionMode = Telerik.XamarinForms.DataControls.ListView.SelectionMode.None;
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var item = (sender as BindableObject).BindingContext as DataItem;
            if (item != null)
            {
                item.IsSpecial = true;
            }
        }
    }
}