using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SDKBrowser.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly ISettings settings;

        public bool IsSplashVisible
        {
            get
            {
                return settings.GetValueOrDefault(nameof(IsSplashVisible), true);
            }
            set
            {
                settings.AddOrUpdateValue(nameof(IsSplashVisible), value);
            }
        }

        public SettingsService()
        {
            this.settings = CrossSettings.Current;
        }
    }
}
