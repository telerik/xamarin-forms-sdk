using Telerik.XamarinForms.Common.UWP;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

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
