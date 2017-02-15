using SDKBrowser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SDKBrowser
{
    public partial class RootPage : ContentPage
    {
        private ExamplesLoader examplesLoader;
        private ListView listView;

        public RootPage(ExamplesLoader loader)
            : this()
        {
            this.examplesLoader = loader;
            this.Title = "Examples";
            this.listView = new ListView();
            this.listView.ItemsSource = examplesLoader.GetAvailableControls();
            this.Content = listView;
            this.listView.ItemTapped += listView_ItemTapped;
        }

        public RootPage()
        {
            InitializeComponent();
        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var control = e.Item.ToString();
            var groups = examplesLoader.GetExamplesGroups(control);

            if (groups.Count() > 0)
            {
                await Navigation.PushAsync(new ExampleGroupPage(groups, control, examplesLoader));
            }
            else
            {
                await Navigation.PushAsync(new ExamplesPage(examplesLoader.GetFlatExamples(control), examplesLoader, control));
            }
        }
    }
}
