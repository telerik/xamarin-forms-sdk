using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.CommandsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCommands : ContentView
    {
        public ListViewCommands()
        {
            InitializeComponent();
            // >> listview-features-commands-add
            listView1.Commands.Add(new ItemTappedUserCommand());
            // << listview-features-commands-add
        }
    }
}