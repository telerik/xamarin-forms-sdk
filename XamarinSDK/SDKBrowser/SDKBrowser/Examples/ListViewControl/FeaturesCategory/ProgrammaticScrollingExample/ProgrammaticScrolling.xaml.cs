using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.ProgrammaticScrollingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgrammaticScrolling : ContentView
    {
        // >> listview-features-programmatic-scrolling
        private Random rnd;
        public ObservableCollection<string> Items { get; set; }
        public ProgrammaticScrolling()
        {
            InitializeComponent();

            this.rnd = new Random();
            this.Items = new ObservableCollection<string>();

            for (int i = 0; i < 100; i++)
            {
                this.Items.Add("Item " + i);
            }

            this.BindingContext = this;
        }
        // << listview-features-programmatic-scrolling

        // >>  listview-features-programmatic-scrolling-scroll-to-item-method
        private void ScrollItemIntoViewClicked(object sender, EventArgs e)
        {
            this.ScrollToItem();
        }
        private void ScrollToItem()
        {
            var item = this.Items[rnd.Next(this.Items.Count - 1)];
            this.label.Text = "Scrolled to: " + item;
            this.listView.ScrollItemIntoView(item);
        }
        // << listview-features-programmatic-scrolling-scroll-to-item-method
    }
}