using Xamarin.Forms;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;

namespace SDKBrowser.Examples.ListViewControl.CellTypesCategory.TemplateCellExample
{
    public class ListViewTemplateCellCSharp : ContentView
    {
        public ListViewTemplateCellCSharp()
        {
            // >> listview-celltypes-templatecell-listview-code
            var listView = new RadListView
            {
                ItemsSource = new ViewModel().Source,
                ItemTemplate = new DataTemplate(() =>
                {
                    return new ListViewTemplateCell
                    {
                        View = GetCellContent()
                    };
                }),
            };
            // << listview-celltypes-templatecell-listview-code

            Content = listView;
        }
        // >> listview-celltypes-templatecell-cellcontent
        public View GetCellContent()
        {
            var content = new Grid();

            var book = new Label
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                FontSize = 16,
                VerticalOptions = LayoutOptions.Center
            };

            book.SetBinding(Label.TextProperty, new Binding(nameof(Book.Title)));

            var fav = new Image
            {
                Source = ImageSource.FromFile("favourite.png"),
                HeightRequest = 16,
                VerticalOptions = LayoutOptions.Center
            };

            fav.SetBinding(Image.IsVisibleProperty, new Binding(nameof(Book.IsFavourite)));

            var author = new Label
            {
                TextColor = Color.Gray,
                FontAttributes = FontAttributes.Italic,
                FontSize = 13
            };

            author.SetBinding(Label.TextProperty, new Binding(nameof(Book.Author)));

            var by = new Label
            {
                Text = "by",
                TextColor = Color.Gray,
                FontAttributes = FontAttributes.Italic,
                FontSize = 13
            };

            var main = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = new Thickness(10, 10, 10, 0) };
            main.Children.Add(fav);
            main.Children.Add(book);

            var detail = new StackLayout { Orientation = StackOrientation.Horizontal, Margin = new Thickness(10, 0, 10, 10) };
            detail.Children.Add(by);
            detail.Children.Add(author);

            content.Children.Add(main, 0, 0);
            content.Children.Add(detail, 0, 1);

            return content;
        }
        // << listview-celltypes-templatecell-cellcontent

    }
}

