using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.StylingCategory.GroupHeaderStyleExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroupHeaderStyle : ContentView
    {
        public ListViewGroupHeaderStyle()
        {
            InitializeComponent();

            // >> listview-groupstyle-setvm
            this.BindingContext = new ViewModel();
            // << listview-groupstyle-setvm
        }
    }
}