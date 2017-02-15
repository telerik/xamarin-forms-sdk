using System.Collections.Generic;
using Xamarin.Forms;

namespace SDKBrowser.Common
{
    public partial class ExamplesPage : ContentPage
    {
        private string control;
        private ExamplesLoader loader;

        public ExamplesPage(IEnumerable<Example> examples, ExamplesLoader loader, string control, string group = null)
            : this()
        {
            this.Title = string.IsNullOrEmpty(group) ? control : string.Format("{0}: {1}", control, group);
            this.control = control;
            this.loader = loader;
            var listView = new ListView
            {
                ItemsSource = examples,
                ItemTemplate = this.Resources["itemTemplate"] as DataTemplate
            };

            listView.ItemTapped += lv_ItemTapped;

            this.Content = listView;
        }

        private async void lv_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var example = e.Item as Example;

            await Navigation.PushAsync(PageFactory.GetPage(control + "." + loader.GetExamplePageName(control, example.GroupName, example.Title), example.Title));
        }

        public ExamplesPage()
        {
            InitializeComponent();
        }
    }
}
