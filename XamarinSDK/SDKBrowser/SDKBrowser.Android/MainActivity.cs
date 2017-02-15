using Android.App;
using Android.Content.PM;
using Android.Net;
using Android.OS;
using SDKBrowser.Common;
using Telerik.XamarinForms.Common.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

// >> chart-getting-started-android-renderers
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.Android.CartesianChartRenderer))]
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(Telerik.XamarinForms.ChartRenderer.Android.PieChartRenderer))]
// << chart-getting-started-android-renderers

// >> calendar-getting-started-android-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.Android.CalendarRenderer))]
// << calendar-getting-started-android-renderer

// >> dataform-getting-started-android-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Input.RadDataForm), typeof(Telerik.XamarinForms.InputRenderer.Android.DataFormRenderer))]
// << dataform-getting-started-android-renderer

// >> listview-getting-started-android-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(Telerik.XamarinForms.DataControlsRenderer.Android.ListViewRenderer))]
// << listview-getting-started-android-renderer

// >> sidedrawer-getting-started-android-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Primitives.RadSideDrawer), typeof(Telerik.XamarinForms.PrimitivesRenderer.Android.SideDrawerRenderer))]
// << sidedrawer-getting-started-android-renderer

// >> autocomplete-getting-started-android-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Input.RadAutoComplete), typeof(Telerik.XamarinForms.InputRenderer.Android.AutoCompleteRenderer))]
// << autocomplete-getting-started-android-renderer

namespace SDKBrowser.Droid
{
    [Activity(Theme = "@style/Theme.AppCompat.NoActionBar", Label = "Telerik UI For Xamarin Forms", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            TelerikForms.Init();

            this.LoadApplication(new App());
        }

        [Java.Interop.Export("NavigateTo")]
        public void NavigateTo(string pageName, string pageTitle)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(PageFactory.GetPage(pageName, pageTitle, true));
        }
    }
}