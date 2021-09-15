using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
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
            Plugin.Media.CrossMedia.Current.Initialize();
            Xamarin.Essentials.Platform.Init(this, bundle);
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

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}