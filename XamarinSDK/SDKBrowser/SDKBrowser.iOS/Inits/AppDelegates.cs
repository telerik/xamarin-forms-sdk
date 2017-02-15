using Foundation;
using UIKit;

namespace SDKBrowser.iOS
{
    public partial class ChartAppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        // >> chart-getting-started-ios-init
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.ChartRenderer.iOS.PieChartRenderer();
            new Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer();

            Xamarin.Forms.Forms.Init();
            Telerik.XamarinForms.Common.iOS.TelerikForms.Init();

            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        // << chart-getting-started-ios-init
    }

    public partial class AutoCompleteAppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        // >> autocomplete-getting-started-ios-init
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.InputRenderer.iOS.AutoCompleteRenderer();

            Xamarin.Forms.Forms.Init();
            Telerik.XamarinForms.Common.iOS.TelerikForms.Init();

            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        // << autocomplete-getting-started-ios-init
    }

    public partial class CalendarAppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        // >> calendar-getting-started-ios-init
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer();

            Xamarin.Forms.Forms.Init();
            Telerik.XamarinForms.Common.iOS.TelerikForms.Init();

            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        // << calendar-getting-started-ios-init
    }

    public partial class SideDrawerAppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        // >> sidedrawer-getting-started-ios-init
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.PrimitivesRenderer.iOS.SideDrawerRenderer();

            Xamarin.Forms.Forms.Init();
            Telerik.XamarinForms.Common.iOS.TelerikForms.Init();

            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        // << sidedrawer-getting-started-ios-init
    }

    public partial class DataFormAppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        // >> dataform-getting-started-ios-init
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.InputRenderer.iOS.DataFormRenderer();

            Xamarin.Forms.Forms.Init();
            Telerik.XamarinForms.Common.iOS.TelerikForms.Init();

            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        // << dataform-getting-started-ios-init
    }

    public partial class ListViewAppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        // >> listview-getting-started-ios-init
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer();

            Xamarin.Forms.Forms.Init();
            Telerik.XamarinForms.Common.iOS.TelerikForms.Init();

            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        // << listview-getting-started-ios-init
    }
}


