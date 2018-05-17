using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.CellTypesCategory.TemplateCellSelectorExample
{
    public partial class ListViewItemTemplateSelectorXaml : ContentView
    {
        public ListViewItemTemplateSelectorXaml()
        {
            this.InitializeComponent();
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