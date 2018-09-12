using System.Linq;
using SDKBrowser.Common;
using SDKBrowser.ViewModels;
using Xamarin.Forms;

namespace SDKBrowser.Services
{
    public class BackdoorService : IBackdoorService
    {
        private readonly IConfigurationService configurationService;
        private readonly INavigationService navigationService;

        public BackdoorService()
        {
            this.configurationService = DependencyService.Get<IConfigurationService>();
            this.navigationService = DependencyService.Get<INavigationService>();
        }

        public string NavigateToExample(string controlName, string exampleName)
        {
            var target = this.configurationService.Configuration.Controls
                .Where(control => control.Name == controlName)
                .SelectMany(control => control.Categories)
                .SelectMany(category => category.Examples)
                .First(example => example.Page == exampleName);

            this.NavigateToExample(target);

            return target.Title;
        }

        private async void NavigateToExample(Example example)
        {
            // This cause crash in XF 3.x so comment out till they fix it.
            // https://github.com/xamarin/Xamarin.Forms/issues/2004
            //await this.navigationService.NavigateToRootAsync();
            await this.navigationService.NavigateToAsync<ExampleViewModel>(example);
        }
    }
}
