using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SDKBrowser.Services
{
    public class NavigationService : INavigationService
    {
        private readonly INavigation navigation;

        public NavigationService()
        {
            this.navigation = Application.Current.MainPage.Navigation;
        }

        public Task NavigateToAsync<TViewModel>(params object[] arguments)
        {
            var page = this.CreatePage<TViewModel>(arguments);

            return this.navigation.PushAsync(page);
        }

        public Task NavigateToRootAsync()
        {
            return this.navigation.PopToRootAsync();
        }

        public Task NavigateBackAsync()
        {
            return this.navigation.PopAsync();
        }

        private Page CreatePage<TViewModel>(params object[] arguments)
        {
            var viewModelType = typeof(TViewModel);
            var viewModelName = viewModelType.FullName;
            var viewName = viewModelName.Replace("ViewModel", "View");
            var viewType = Type.GetType(viewName);
            var view = (Page)Activator.CreateInstance(viewType);
            var viewModel = Activator.CreateInstance(viewModelType, arguments);

            view.BindingContext = viewModel;

            return view;
        }
    }
}
