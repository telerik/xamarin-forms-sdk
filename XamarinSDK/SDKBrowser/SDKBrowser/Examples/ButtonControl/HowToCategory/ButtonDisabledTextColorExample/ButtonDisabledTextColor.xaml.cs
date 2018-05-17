using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ButtonControl.HowToCategory.ButtonDisabledTextColorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonDisabledTextColor : ContentView
    {
        public ButtonDisabledTextColor()
        {
            this.InitializeComponent();
        }

        private void enabledBtn_Clicked(object sender, System.EventArgs e)
        {
            btn.IsEnabled = !btn.IsEnabled;
            if (btn.IsEnabled)
            {
                btn.Text = "Button is enabled!";
            }
            else
            {
                btn.Text = "Button is disabled!";
            }
        }
       
    }
}