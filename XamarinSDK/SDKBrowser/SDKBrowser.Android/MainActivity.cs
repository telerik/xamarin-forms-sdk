using Android.App;
using Android.Content.PM;
using Android.OS;
using AndroidX.AppCompat.App;
using SDKBrowser.Services;
using System.Collections.Generic;
using Telerik.XamarinForms.Common.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace SDKBrowser.Droid
{
    [Activity(Theme = "@style/Theme.AppCompat.NoActionBar", Label = "Telerik UI For Xamarin", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            StrictMode.VmPolicy.Builder builder = new StrictMode.VmPolicy.Builder();
            StrictMode.SetVmPolicy(builder.Build());

            base.OnCreate(bundle);
            Forms.Init(this, bundle);

            this.SetTheme(Resource.Style.Theme_Design_Light);

            PermissionsHelper.Activity = this;

            TypeRegister.Register(typeof(List<string>), typeof(Android.Runtime.JavaList), new JavaToCSharpListConverter());
            AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightNo;
            this.LoadApplication(new App());
        }

        [Java.Interop.Export("NavigateTo")]
        public string NavigateTo(string controlName, string exampleName)
        {
            var backdoorService = DependencyService.Get<IBackdoorService>();

            return backdoorService.NavigateToExample(controlName, exampleName);
        }
    }
}