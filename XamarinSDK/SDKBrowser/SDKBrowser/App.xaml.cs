using SDKBrowser.Services;
using SDKBrowser.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
            this.InitializeDependencies();
            this.InitializeRootPage();
        }

        private void InitializeDependencies()
        {
            DependencyService.Register<IConfigurationService, ConfigurationService>();
            DependencyService.Register<INavigationService, NavigationService>();
            DependencyService.Register<ISettingsService, SettingsService>();
            DependencyService.Register<IExampleService, ExampleService>();
            DependencyService.Register<IBackdoorService, BackdoorService>();
        }

        private void InitializeRootPage()
        {
            var navigationService = DependencyService.Get<INavigationService>();
            var settingsService = DependencyService.Get<ISettingsService>();

            if (settingsService.IsSplashVisible)
            {
                navigationService.NavigateToAsync<SplashViewModel>();
            }
            else
            {
                navigationService.NavigateToAsync<HomeViewModel>();
            }
        }
    }
}
