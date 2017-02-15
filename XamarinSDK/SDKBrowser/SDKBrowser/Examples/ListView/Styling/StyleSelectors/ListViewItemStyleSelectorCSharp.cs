using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;
using SDKBrowser.Examples.ListView.Styling.StyleSelectors;

namespace SDKBrowser.Examples.ListView
{
    public class ListViewItemStyleSelectorCSharp : ContentPage
    {
        public ListViewItemStyleSelectorCSharp()
        {
            // >> listview-gettingstarted-listview-csharp
            var listView = new RadListView
            {
                ItemsSource = new ViewModel().Source,
                ItemTemplate = new DataTemplate(() =>
                {
                    var label = new Label { Margin = new Thickness(10) };
                    var labelAge = new Label { Margin = new Thickness(10), FontSize = 10 };
                    var content = new StackLayout();
                    content.Children.Add(label);
                    label.SetBinding(Label.TextProperty, new Binding(nameof(SourceItem.Name)));

                    content.Children.Add(labelAge);
                    labelAge.SetBinding(Label.TextProperty, new Binding(nameof(SourceItem.Age)));

                    return new ListViewTemplateCell
                    {
                        View = content
                    };
                })
            };
            // << listview-gettingstarted-listview-csharp

            listView.ItemStyleSelector = new ExampleListViewStyleSelector();

            Content = listView;
        }
    }
}

