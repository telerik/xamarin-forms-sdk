using Xamarin.Forms;

// >> common-type-not-found-csharp
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SDKBrowser.Examples.CalendarControl.GettingStartedCategory.GettingStartedExample
{
    public partial class CalendarGettingStartedXaml : ContentView
    {
        public CalendarGettingStartedXaml()
        {
            this.InitializeComponent();
        }
    }
}
// << common-type-not-found-csharp
