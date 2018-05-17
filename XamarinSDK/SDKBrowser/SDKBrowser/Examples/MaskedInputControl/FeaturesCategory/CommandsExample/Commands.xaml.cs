using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MaskedInputControl.FeaturesCategory.CommandsExample
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Commands : ContentView
    {
        public Commands()
        {
            this.InitializeComponent();

            // >>  maskedinput-features-commands-applymaskstarted-added
            this.input.Commands.Add(new CustomBeforeTextMaskedCommand());
            // <<  maskedinput-features-commands-applymaskstarted-added

            // >>  maskedinput-features-commands-applymaskfinished-added
            this.input.Commands.Add(new CustomAfterTextMaskedCommand());
            // <<  maskedinput-features-commands-applymaskfinished-added
        }
    }
   
}