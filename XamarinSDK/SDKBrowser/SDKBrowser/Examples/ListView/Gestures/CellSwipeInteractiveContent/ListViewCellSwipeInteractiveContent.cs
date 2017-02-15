using Xamarin.Forms;
using SDKBrowser.Examples.ListView.Gestures.CellSwipeInteractiveContent;
using System;

namespace SDKBrowser.Examples.ListView
{
    public partial class ListViewCellSwipeInteractiveContent : ContentPage
    {
        public ListViewCellSwipeInteractiveContent()
        {
            InitializeComponent();
        }

        // >> listview-gestures-cellswipe-interactivecontent-deleteitem
        void RemoveBook(object sender, EventArgs e)
        {
            var item = (sender as BindableObject).BindingContext as Book;
            (this.BindingContext as ViewModel).Source.Remove(item);
        }
        // << listview-gestures-cellswipe-interactivecontent-deleteitem
    }
}
