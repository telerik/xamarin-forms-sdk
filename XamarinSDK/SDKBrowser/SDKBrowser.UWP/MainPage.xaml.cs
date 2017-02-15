using Telerik.XamarinForms.Common.UWP;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

// >> chart-getting-started-uwp-renderers
[assembly: Xamarin.Forms.Platform.UWP.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.UWP.CartesianChartRenderer))]
[assembly: Xamarin.Forms.Platform.UWP.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(Telerik.XamarinForms.ChartRenderer.UWP.PieChartRenderer))]
// << chart-getting-started-uwp-renderers

// >> calendar-getting-started-uwp-renderer
[assembly: Xamarin.Forms.Platform.UWP.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.UWP.CalendarRenderer))]
// << calendar-getting-started-uwp-renderer

// >> sidedrawer-getting-started-uwp-renderer
[assembly: Xamarin.Forms.Platform.UWP.ExportRenderer(typeof(Telerik.XamarinForms.Primitives.RadSideDrawer), typeof(Telerik.XamarinForms.PrimitivesRenderer.UWP.SideDrawerRenderer))]
// << sidedrawer-getting-started-uwp-renderer

// >> listview-getting-started-uwp-renderer
[assembly: Xamarin.Forms.Platform.UWP.ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(Telerik.XamarinForms.DataControlsRenderer.UWP.ListViewRenderer))]
// << listview-getting-started-uwp-renderer

// >> dataform-getting-started-uwp-renderer
[assembly: Xamarin.Forms.Platform.UWP.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadDataForm), typeof(Telerik.XamarinForms.InputRenderer.UWP.DataFormRenderer))]
// << dataform-getting-started-uwp-renderer

// >> autocomplete-getting-started-uwp-renderer
[assembly: Xamarin.Forms.Platform.UWP.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadAutoComplete), typeof(Telerik.XamarinForms.InputRenderer.UWP.AutoCompleteRenderer))]
// << autocomplete-getting-started-uwp-renderer

namespace SDKBrowser.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new SDKBrowser.App());
            TelerikForms.Init();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var appView = ApplicationView.GetForCurrentView();
            appView.SetDesiredBoundsMode(ApplicationViewBoundsMode.UseVisible);
            var top = appView.VisibleBounds.Top - Window.Current.Bounds.Top;
            this.Margin = new Thickness(this.Margin.Left, top, this.Margin.Right, this.Margin.Bottom);
        }
    }
}
