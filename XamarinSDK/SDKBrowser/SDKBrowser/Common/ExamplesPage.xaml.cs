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
            string controlName = ControlNameConverter.Convert(control);
            this.Title = string.IsNullOrEmpty(group) ? controlName : string.Format("{0}: {1}", controlName, group);
            this.control = control;
            this.loader = loader;
            this.listView.ItemsSource = examples;
        }

        public ExamplesPage()
        {
            InitializeComponent();
        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var example = e.Item as Example;

            await Navigation.PushAsync(PageFactory.GetPage(control + "." + loader.GetExamplePageName(control, example.GroupName, example.Title), example.Title));
        }
    }
}
