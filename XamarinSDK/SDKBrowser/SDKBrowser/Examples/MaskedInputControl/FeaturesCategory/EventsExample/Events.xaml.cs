using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MaskedInputControl.FeaturesCategory.EventsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Events : ContentView
    {
        public Events()
        {
            this.InitializeComponent();
           
            // >> maskedinput-features-events-applymaskstarted-csharp
            this.input.ApplyMaskStarted += Input_BeforeTextMasked;
            // << maskedinput-features-events-applymaskstarted-csharp

            // >> maskedinput-features-events-applymaskfinished-csharp
            this.input.ApplyMaskFinished += Input_AfterTextMasked;
            // << maskedinput-features-events-applymaskfinished-csharp
        }

        // >> maskedinput-features-events-applymaskstarted-handler
        private void Input_BeforeTextMasked(object sender, Telerik.XamarinForms.Input.MaskedInput.ApplyMaskStartedEventArgs e)
        {
            e.NewDisplayedText = e.NewDisplayedText.ToUpper();
        }
        // << maskedinput-features-events-applymaskstarted-handler

        // >> maskedinput-features-events-applymaskfinished-handler
        private int lastValidCaretPosition = 0;
        private void Input_AfterTextMasked(object sender, Telerik.XamarinForms.Input.MaskedInput.ApplyMaskFinishedEventArgs e)
        {
            if (e.NewDisplayedText.Contains("X"))
            {
                e.IsAccepted = false;
                e.CaretPosition = lastValidCaretPosition;
            }
            else
            {
                lastValidCaretPosition = e.CaretPosition;
            }
        }
        // << maskedinput-features-events-applymaskfinished-handler
    }
}