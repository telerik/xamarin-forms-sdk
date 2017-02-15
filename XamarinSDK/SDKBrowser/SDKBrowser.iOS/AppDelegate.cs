using Foundation;
using SDKBrowser.Common;
using Telerik.XamarinForms.Common.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

// >> chart-getting-started-ios-renderers
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer))]
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(Telerik.XamarinForms.ChartRenderer.iOS.PieChartRenderer))]
// << chart-getting-started-ios-renderers

// >> calendar-getting-started-ios-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer))]
// << calendar-getting-started-ios-renderer

// >> dataform-getting-started-ios-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Input.RadDataForm), typeof(Telerik.XamarinForms.InputRenderer.iOS.DataFormRenderer))]
// << dataform-getting-started-ios-renderer

// >> listview-getting-started-ios-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer))]
// << listview-getting-started-ios-renderer

// >> sidedrawer-getting-started-ios-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Primitives.RadSideDrawer), typeof(Telerik.XamarinForms.PrimitivesRenderer.iOS.SideDrawerRenderer))]
// << sidedrawer-getting-started-ios-renderer

// >> autocomplete-getting-started-ios-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Input.RadAutoComplete), typeof(Telerik.XamarinForms.InputRenderer.iOS.AutoCompleteRenderer))]
// << autocomplete-getting-started-ios-renderer

[assembly: ExportRenderer(typeof(Xamarin.Forms.NavigationPage), typeof(SDKBrowser.iOS.CustomNavigationRenderer))]

namespace SDKBrowser.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

			new Telerik.XamarinForms.ChartRenderer.iOS.PieChartRenderer();
			new Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer();
			new Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer();
			new Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer();
			new Telerik.XamarinForms.PrimitivesRenderer.iOS.SideDrawerRenderer();
			new Telerik.XamarinForms.DataVisualization.Gauges.RadRadialGauge();

            TelerikForms.Init();

            this.LoadApplication(new App());
            Xamarin.Calabash.Start();

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
