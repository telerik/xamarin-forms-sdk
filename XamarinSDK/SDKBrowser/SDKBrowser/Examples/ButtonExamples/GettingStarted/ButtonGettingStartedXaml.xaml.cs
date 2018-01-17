using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ButtonExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonGettingStartedXaml : ContentPage
    {
        public ButtonGettingStartedXaml()
        {
            InitializeComponent();
        }
        // >> button-getting-started-click-event
        private void button_Clicked(object sender, System.EventArgs e)
        {
           //implement your logic here.
        }
        // << button-getting-started-click-event
    }
}