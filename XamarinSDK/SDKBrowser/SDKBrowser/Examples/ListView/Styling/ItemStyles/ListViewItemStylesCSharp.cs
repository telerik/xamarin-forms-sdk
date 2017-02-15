using SDKBrowser.Examples.ListView.ItemStyles;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListView
{
    public class ListViewItemStylesCSharp : ContentPage
    {
        public ListViewItemStylesCSharp()
        {
            // >> listview-styling-listview-csharp
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
            // << listview-styling-listview-csharp

            var pressedStyle = new ListViewItemStyle()
            {
                BackgroundColor = Color.Lime,
                BorderColor = Color.Red,
                BorderWidth = 2,
                BorderLocation = Telerik.XamarinForms.Common.Location.Bottom
            };
            listView.PressedItemStyle = pressedStyle;

            var selectedStyle = new ListViewItemStyle()
            {
                BackgroundColor = Color.Purple,
                BorderColor = Color.Aqua,
                BorderWidth = 2,
                BorderLocation = Telerik.XamarinForms.Common.Location.Bottom
            };
            listView.SelectedItemStyle = selectedStyle;

            var normalStyle = new ListViewItemStyle()
            {
                BackgroundColor = Color.Gray,
            };

            listView.ItemStyle = normalStyle;



            Content = listView;
        }
    }
}

