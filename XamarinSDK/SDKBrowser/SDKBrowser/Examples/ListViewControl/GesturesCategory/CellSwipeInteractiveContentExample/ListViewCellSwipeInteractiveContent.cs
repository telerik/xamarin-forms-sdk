using System;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.GesturesCategory.CellSwipeInteractiveContentExample
{
    public partial class ListViewCellSwipeInteractiveContent : ContentView
    {
        public ListViewCellSwipeInteractiveContent()
        {
            this.InitializeComponent();
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
