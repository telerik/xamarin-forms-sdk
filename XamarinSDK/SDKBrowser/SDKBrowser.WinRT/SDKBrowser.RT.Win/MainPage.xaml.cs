using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// >> chart-getting-started-winrt-renderers
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.WinRT.CartesianChartRenderer))]
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(Telerik.XamarinForms.ChartRenderer.WinRT.PieChartRenderer))]
// << chart-getting-started-winrt-renderers

// >> calendar-getting-started-winrt-renderer
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.WinRT.CalendarRenderer))]
// << calendar-getting-started-winrt-renderer

// >> sidedrawer-getting-started-winrt-renderer
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Primitives.RadSideDrawer), typeof(Telerik.XamarinForms.PrimitivesRenderer.WinRT.SideDrawerRenderer))]
// << sidedrawer-getting-started-winrt-renderer

// >> listview-getting-started-winrt-renderer
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(Telerik.XamarinForms.DataControlsRenderer.WinRT.ListViewRenderer))]
// << listview-getting-started-winrt-renderer

// >> dataform-getting-started-winrt-renderer
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadDataForm), typeof(Telerik.XamarinForms.InputRenderer.WinRT.DataFormRenderer))]
// << dataform-getting-started-winrt-renderer

[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadAutoComplete), typeof(Telerik.XamarinForms.InputRenderer.WinRT.AutoCompleteRenderer))]


namespace SDKBrowser.WinRT
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new SDKBrowser.App());

            this.Tapped += MainPage_Tapped;
        }

        private void MainPage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (this.BottomAppBar != null)
            {
                this.BottomAppBar.IsSticky = true;
                this.BottomAppBar.Opened += BottomAppBar_Opened;
                var commands = ((CommandBar)this.BottomAppBar).PrimaryCommands.Count;
                var commands2 = ((CommandBar)this.BottomAppBar).SecondaryCommands.Count;
            }
        }

        private void BottomAppBar_Opened(object sender, object e)
        {
            Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                var button = Telerik.Core.ElementTreeHelper.FindVisualDescendant<AppBarButton>(sender as DependencyObject);
            });
        }
    }
}
