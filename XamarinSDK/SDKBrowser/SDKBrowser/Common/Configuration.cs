using System.Collections.Generic;

namespace SDKBrowser.Common
{
    public class Configuration
    {
        public string HeaderTitle { get; set; }
        public string HeaderIcon { get; set; }
        public string SplashTitle { get; set; }
        public string SplashIcon { get; set; }
        public string SplashInfo { get; set; }
        public string SourceUrl { get; set; }
        public List<Control> Controls { get; set; }
    }
}
