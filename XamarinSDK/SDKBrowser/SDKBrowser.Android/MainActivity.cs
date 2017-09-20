using Android.App;
using Android.Content.PM;
using Android.OS;
using SDKBrowser.Common;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace SDKBrowser.Droid
{
    [Activity(Theme = "@style/Theme.AppCompat.NoActionBar", Label = "Progress Telerik UI For Xamarin", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init(this, bundle);

            this.LoadApplication(new App());
        }

        [Java.Interop.Export("NavigateTo")]
        public void NavigateTo(string pageName, string pageTitle)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(PageFactory.GetPage(pageName, pageTitle, true));
        }
    }
}