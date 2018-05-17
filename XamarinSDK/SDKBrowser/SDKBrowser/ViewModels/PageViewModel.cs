using System;
using SDKBrowser.Services;
using Xamarin.Forms;

namespace SDKBrowser.ViewModels
{
    public abstract class PageViewModel : ViewModelBase
    {
        private string headerTitle;
        private string headerIcon;
        private bool isBackVisible;

        public string HeaderTitle
        {
            get
            {
                return this.headerTitle;
            }
            protected set
            {
                if (this.headerTitle != value)
                {
                    this.headerTitle = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public string HeaderIcon
        {
            get
            {
                return this.headerIcon;
            }
            protected set
            {
                if (this.headerIcon != value)
                {
                    this.headerIcon = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public bool IsBackVisible
        {
            get
            {
                return this.isBackVisible;
            }
            protected set
            {
                if (this.isBackVisible != value)
                {
                    this.isBackVisible = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public Command BackCommand { get; private set; }

        public PageViewModel()
        {
            this.BackCommand = new Command(this.OnBackCommand);
        }

        private void OnBackCommand()
        {
            var navigationService = DependencyService.Get<INavigationService>();

            navigationService.NavigateBackAsync();
        }
    }
}
