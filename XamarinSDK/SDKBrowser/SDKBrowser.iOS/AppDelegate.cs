using Foundation;
using SDKBrowser.Common;
using Telerik.XamarinForms.Common.iOS;
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
            string[] parts = allParams.ToString().Split(',');
            string pageName = parts[0];
            string pageTitle = parts[1];
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(PageFactory.GetPage(pageName, pageTitle, true));

            return new NSString("done");
        }
    }
}
