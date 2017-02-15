using Telerik.XamarinForms.Common.WinPhone;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

// >> chart-getting-started-wp-renderers
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.WinPhone.CartesianChartRenderer))]
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(Telerik.XamarinForms.ChartRenderer.WinPhone.PieChartRenderer))]
// << chart-getting-started-wp-renderers

// >> calendar-getting-started-wp-renderer
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.WinPhone.CalendarRenderer))]
// << calendar-getting-started-wp-renderer

namespace SDKBrowser.WinPhone
{
    public partial class MainPage : FormsApplicationPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            Forms.Init();

            this.LoadApplication(new SDKBrowser.App());
        }
    }
}
