using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.ItemSpacingExample
{
    public partial class ItemSpacing : ContentView
    {
        public ItemSpacing()
        {
            this.InitializeComponent();

            this.listView.ItemsSource = this.GetData(100);
        }

        private IEnumerable GetData(int p)
        {
            var result = new List<Item>();
            for (int i = 0; i < p; i++)
            {
                result.Add(new Item() { Name = string.Format("Item {0}", i) });
            }
            return result;
        }

        private void IncreaseHorizontalSpacing(object s, EventArgs e)
        {
            var layout = this.listView.LayoutDefinition as ListViewGridLayout;
            layout.VerticalItemSpacing += 10;
        }

        private void DecreaseHorizontalSpacing(object s, EventArgs e)
        {
            var layout = this.listView.LayoutDefinition as ListViewGridLayout;
            if (layout.VerticalItemSpacing >= 10)
            {
                layout.VerticalItemSpacing -= 10;
            }
        }

        private void IncreaseVerticalSpacing(object s, EventArgs e)
        {
            var layout = this.listView.LayoutDefinition as ListViewGridLayout;
            layout.HorizontalItemSpacing += 10;
        }

        private void DecreaseVerticalSpacing(object s, EventArgs e)
        {
            var layout = this.listView.LayoutDefinition as ListViewGridLayout;
            if (layout.HorizontalItemSpacing >= 10)
            {
                layout.HorizontalItemSpacing -= 10;
            }
        }
    }
}