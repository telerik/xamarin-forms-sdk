using System.Collections.Generic;
using Xamarin.Forms;

namespace SDKBrowser.Common
{
    public partial class ExampleGroupPage : ContentPage
    {
        private string control;
        private ExamplesLoader examplesLoader;

        public ExampleGroupPage(IEnumerable<ExampleGroup> examplesGroups, string control, ExamplesLoader loader)
            : this()
        {
            this.Title = ControlNameConverter.Convert(control);
            this.control = control;
            this.examplesLoader = loader;
            this.listView.ItemsSource = examplesGroups;
        }

        public ExampleGroupPage()
        {
            InitializeComponent();
        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var group = e.Item as ExampleGroup;

            await Navigation.PushAsync(new ExamplesPage(group.Examples, examplesLoader, control, group.Name));
        }
    }
}
