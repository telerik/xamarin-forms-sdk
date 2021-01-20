using Foundation;
using SDKBrowser.Services;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.Linq;

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
            Xamarin.Forms.Application.Current.UserAppTheme = OSAppTheme.Light;
            Xamarin.Forms.Application.Current.RequestedThemeChanged += this.OnRequestedThemeChanged;

            return base.FinishedLaunching(app, options);
        }

        private void OnRequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            this.Window.OverrideUserInterfaceStyle = UIUserInterfaceStyle.Light;
        }

#if TESTS
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

        [Export("ChangeToday:")]
        public void ChangeDateTimeToday(string dateString)
        {
            var date = System.DateTime.Parse(dateString).ToNSDate();
            TelerikUI.TKTestUtilities.SetDateTimeNow(date);
        }

        [Export("RestoreToday")]
        public void RestoreToday()
        {
            TelerikUI.TKTestUtilities.RestoreDateTimeNow();
        }

        [Export("SetCalendarDate:")]
        public void SetCalendarDate(string dateString)
        {
            var calendarView = TelerikUI.VisualTreeHelper.FindVisualDescendants
                                        <Telerik.XamarinForms.InputRenderer.iOS.TKExtendedCalendar>(UIApplication.SharedApplication.KeyWindow).FirstOrDefault();
            if (calendarView != null)
            {
                calendarView.NavigateToDate(System.DateTime.Parse(dateString).ToNSDate(), false);
            }
        }
#endif
    }
}
