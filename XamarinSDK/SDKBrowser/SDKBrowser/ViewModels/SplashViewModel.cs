using SDKBrowser.Services;
using Xamarin.Forms;

namespace SDKBrowser.ViewModels
{
    public class SplashViewModel : PageViewModel
    {
        private string splashTitle;
        private string splashIcon;
        private string splashInfo;

        public string SplashTitle
        {
            get
            {
                return this.splashTitle;
            }
            private set
            {
                if (this.splashTitle != value)
                {
                    this.splashTitle = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public string SplashIcon
        {
            get
            {
                return this.splashIcon;
            }
            private set
            {
                if (this.splashIcon != value)
                {
                    this.splashIcon = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public string SplashInfo
        {
            get
            {
                return this.splashInfo;
            }
            private set
            {
                if (this.splashInfo != value)
                {
                    this.splashInfo = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public Command NextCommand { get; private set; }

        public SplashViewModel()
        {
            var configurationService = DependencyService.Get<IConfigurationService>();
            var configuration = configurationService.Configuration;

            this.HeaderTitle = configuration.HeaderTitle;
            this.HeaderIcon = configuration.HeaderIcon;
            this.SplashTitle = configuration.SplashTitle;
            this.SplashIcon = configuration.SplashIcon;
            this.SplashInfo = configuration.SplashInfo;
            this.NextCommand = new Command(this.OnNextCommand);
        }

        private void OnNextCommand()
        {
            var settingsService = DependencyService.Get<ISettingsService>();

            settingsService.IsSplashVisible = false;

            var navigationService = DependencyService.Get<INavigationService>();

            navigationService.NavigateToAsync<HomeViewModel>();
        }
    }
}
