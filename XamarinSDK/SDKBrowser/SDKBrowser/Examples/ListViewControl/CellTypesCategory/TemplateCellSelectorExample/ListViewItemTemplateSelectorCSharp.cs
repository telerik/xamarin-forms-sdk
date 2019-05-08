using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;
using SelectionMode = Telerik.XamarinForms.DataControls.ListView.SelectionMode;

namespace SDKBrowser.Examples.ListViewControl.CellTypesCategory.TemplateCellSelectorExample
{
    public class ListViewItemTemplateSelectorCSharp : ContentView
    {
        public ListViewItemTemplateSelectorCSharp()
        {
            var listView = new RadListView
            {
                ItemsSource = new ViewModel().Source,
                SelectionMode = SelectionMode.None,
                ItemTemplateSelector = new CustomItemTemplateSelector
                {
                    Template1 = this.GetTemplate1(),
                    Template2 = this.GetTemplate2()
                }
            };

            Content = listView;
        }

        private DataTemplate GetTemplate1()
        {
            var dataTemplate = new DataTemplate(() =>
            {
                var content = new Grid();
                var itemNameLabel = new Label
                {
                    Margin = 10
                };
                itemNameLabel.SetBinding(Label.TextProperty, new Binding(nameof(DataItem.Name)));
                Grid.SetColumn(itemNameLabel, 0);

                var button = new Button
                {
                    Text = "Mark as Special"
                };
                Grid.SetColumn(button, 1);
                button.Clicked += Button_Clicked;

                content.Children.Add(itemNameLabel);
                content.Children.Add(button);
                return new ListViewTemplateCell { View = content };
            });

            return dataTemplate;
        }

        private DataTemplate GetTemplate2()
        {
            var dataTemplate = new DataTemplate(() =>
            {
                var content = new Grid();

                var itemNameLabel = new Label
                {
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 16,
                    VerticalOptions = LayoutOptions.Center
                };

                itemNameLabel.SetBinding(Label.TextProperty, new Binding(nameof(DataItem.Name)));

                var itemDescriptionLabel = new Label
                {
                    TextColor = Color.Gray,
                    FontAttributes = FontAttributes.Italic,
                    FontSize = 13,
                    Text = "Special Item "
                };

                var main = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = new Thickness(10, 10, 10, 0) };
                main.Children.Add(itemNameLabel);

                var detail = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = new Thickness(10, 0, 10, 10) };
                detail.Children.Add(itemDescriptionLabel);

                content.Children.Add(main, 0, 0);
                content.Children.Add(detail, 0, 1);
                content.BackgroundColor = Color.Orange;

                return new ListViewTemplateCell { View = content };
            });

            return dataTemplate;
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
