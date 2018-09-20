using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.SlideViewControl.FeaturesCategory.CommandsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Commands : ContentView
    {
        public Commands()
        {
            InitializeComponent();
            // >> slideview-commands-add
            this.slideView.Commands.Add(new CustomSlideViewCommand());
            // << slideview-commands-add
        }
    }
}