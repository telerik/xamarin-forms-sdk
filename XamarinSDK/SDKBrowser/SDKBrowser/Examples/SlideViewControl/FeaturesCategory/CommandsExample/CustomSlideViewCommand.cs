using Telerik.XamarinForms.Primitives.SlideView.Commands;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SlideViewControl.FeaturesCategory.CommandsExample
{
    // >> slideview-commands-customcommand
    public class CustomSlideViewCommand : SlideViewCommand
    {
        public CustomSlideViewCommand()
        {
            this.Id = SlideViewCommandId.SlidingToIndex;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            var slidedToIndex = (parameter as SlideViewSlidingToIndexCommandContext).Index;
            //add your logic here
            Application.Current.MainPage.DisplayAlert("", "You're about to go to slide " + slidedToIndex, "OK");
            base.Execute(parameter);           
        }
    }
    // << slideview-commands-customcommand
}
