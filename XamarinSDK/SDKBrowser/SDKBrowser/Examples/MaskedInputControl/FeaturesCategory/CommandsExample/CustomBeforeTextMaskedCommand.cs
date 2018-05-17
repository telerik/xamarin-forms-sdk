using Telerik.XamarinForms.Input.MaskedInput;

namespace SDKBrowser.Examples.MaskedInputControl.FeaturesCategory.CommandsExample
{
    // >> maskedinput-features-commands-applymaskstarted-implementation
    public class CustomBeforeTextMaskedCommand : MaskedInputCommandBase
    {
        public CustomBeforeTextMaskedCommand()
        {
            this.Id = MaskedInputCommandId.ApplyMaskStarted;
        }

        public override void Execute(object parameter)
        {
            var context = parameter as ApplyMaskStartedCommandContext;
            context.NewDisplayedText = context.NewDisplayedText.ToUpper();
        }
    }
    // <<  maskedinput-features-commands-applymaskstarted-implementation
}