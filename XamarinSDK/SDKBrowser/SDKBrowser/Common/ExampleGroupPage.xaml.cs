using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.Title = control;
            this.control = control;
            this.examplesLoader = loader;
            ListView lv;
            this.Content = lv = new ListView() { ItemsSource = examplesGroups };

            lv.ItemTapped += lv_ItemTapped;
        }

        private async void lv_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var group = e.Item as ExampleGroup;

            await Navigation.PushAsync(new ExamplesPage(group.Examples, examplesLoader, control, group.Name));
        }

        public ExampleGroupPage()
        {
            InitializeComponent();
        }
    }
}
