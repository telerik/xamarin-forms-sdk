using Foundation;
using SDKBrowser.Services;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Xamarin.Forms.NavigationPage), typeof(SDKBrowser.iOS.CustomNavigationRenderer))]

namespace SDKBrowser.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();
            
            this.LoadApplication(new App());
#if TESTS
            Xamarin.Calabash.Start();
#endif

            return base.FinishedLaunching(app, options);
        }

        [Export("NavigateTo:")]
        public NSString NavigateTo(NSString allParams)
        {
            var parts = allParams.ToString().Split(',');
            var controlName = parts[0];
            var exampleName = parts[1];

            var backdoorService = DependencyService.Get<IBackdoorService>();
            var exampleTitle = backdoorService.NavigateToExample(controlName, exampleName);

            return new NSString(exampleTitle);
        }
    }
}
