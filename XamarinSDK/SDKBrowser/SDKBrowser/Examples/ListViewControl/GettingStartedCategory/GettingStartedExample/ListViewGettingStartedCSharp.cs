using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.GettingStartedCategory.GettingStartedExample
{
    public class ListViewGettingStartedCSharp : ContentView
    {
        public ListViewGettingStartedCSharp()
        {
            // >> listview-gettingstarted-listview-csharp
            var listView = new RadListView
            {
                ItemsSource = new ViewModel().Source,
                ItemTemplate = new DataTemplate(() =>
                {
                    var label = new Label { Margin = new Thickness(10) };
                    var content = new Grid();
                    content.Children.Add(label);
                    label.SetBinding(Label.TextProperty, new Binding(nameof(SourceItem.Name)));

                    return new ListViewTemplateCell
                    {
                        View = content
                    };
                })
            };
            // << listview-gettingstarted-listview-csharp

            Content = listView;
        }
    }
}

