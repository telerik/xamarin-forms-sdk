using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.ProgrammaticScrollingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgrammaticScrolling : ContentView
    {
        public ProgrammaticScrolling ()
        {
            InitializeComponent ();
            this.BindingContext = new ViewModel();
            
        }
        // >> treeview-programmaticscrolling-code
        private void ScrollItemIntoViewClicked(object sender, EventArgs e)
        {
            var item = GetItemToScroll();
            if (this.treeView.ScrollItemIntoView(item))
            {
                this.label.Text = "Scrolled to: " + item;
            }
            else
            {
                this.label.Text = item + " is either collapsed or does not exist";
            }
        }
        private Item GetItemToScroll()
        {
            return ((treeView.ItemsSource as ObservableCollection<Item>).LastOrDefault() as Item).Children.LastOrDefault();
        }
        // << treeview-programmaticscrolling-code
    }
}