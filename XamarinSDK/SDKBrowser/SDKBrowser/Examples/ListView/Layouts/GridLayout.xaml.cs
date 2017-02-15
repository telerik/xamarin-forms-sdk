using System.Collections.Generic;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListView
{
    public partial class GridLayout : ContentPage
    {
        public GridLayout()
        {
            InitializeComponent();
            // >> listview-layouts-gridlayout-source
            var colors = new List<object>();
            for (int i = 0; i < 16; i++)
            {
                var c = 200 - 10 * i;
                colors.Add(new { Color = Color.FromRgb(c, c, c) });
            };

            listView.ItemsSource = colors;
            // << listview-layouts-gridlayout-source
        }
    }
}
