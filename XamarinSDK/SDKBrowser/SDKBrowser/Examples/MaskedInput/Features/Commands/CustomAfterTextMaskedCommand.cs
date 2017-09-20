using Telerik.XamarinForms.Input.MaskedInput;

namespace SDKBrowser.Examples.MaskedInput
{
    // >> maskedinput-features-commands-applymaskfinished-implementation
    public class CustomAfterTextMaskedCommand : MaskedInputCommandBase
    {
        public CustomAfterTextMaskedCommand()
        {
            this.Id = MaskedInputCommandId.ApplyMaskFinished;
        }

        private int lastValidCaretPosition = 0;
        public override void Execute(object parameter)
        {
            var context = parameter as ApplyMaskFinishedCommandContext;
            if (context.NewDisplayedText.Contains("X"))
            {
                context.IsAccepted = false;
                context.CaretPosition = lastValidCaretPosition;
            }
            else
            {
                lastValidCaretPosition = context.CaretPosition;
            }
        }
    }
    // <<  maskedinput-features-commands-applymaskfinished-implementation
}