using System.Threading.Tasks;

namespace SDKBrowser.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync<TViewModel>(params object[] arguments);
        Task NavigateToRootAsync();
        Task NavigateBackAsync();
    }
}