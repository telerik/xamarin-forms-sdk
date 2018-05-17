using SDKBrowser.Common;

namespace SDKBrowser.Services
{
    public interface IExampleService
    {
        object CreateExample(Example example);
        void OpenExample(Example example);
    }
}