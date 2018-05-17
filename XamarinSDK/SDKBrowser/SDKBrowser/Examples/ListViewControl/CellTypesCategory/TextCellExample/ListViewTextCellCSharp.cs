using Xamarin.Forms;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;

namespace SDKBrowser.Examples.ListViewControl.CellTypesCategory.TextCellExample
{
    public class ListViewTextCellCSharp : ContentView
    {
        public ListViewTextCellCSharp()
        {
            // >> listview-celltypes-textcell-listview-csharp
            var listView = new RadListView
            {
                ItemsSource = new ViewModel().Source,
                ItemTemplate = new DataTemplate(() =>
                {
                    var cell = new ListViewTextCell
                    {
                        TextColor = Color.Black,
                        DetailColor = Color.Gray,
                    };

                    cell.SetBinding(ListViewTextCell.TextProperty, new Binding(nameof(Book.Title)));
                    cell.SetBinding(ListViewTextCell.DetailProperty, new Binding(nameof(Book.Author)));

                    return cell;
                }),
                LayoutDefinition = new ListViewLinearLayout { ItemLength = 70 },
            };
            // << listview-celltypes-textcell-listview-csharp

            Content = listView;
        }
    }
}

