using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SDKBrowser.Views
{
    public class ViewBase : ContentPage
    {
        public static readonly BindableProperty IsBackVisibleProperty =
            BindableProperty.Create(nameof(IsBackVisible), typeof(bool), typeof(ViewBase), false);
        public static readonly BindableProperty IsMenuVisibleProperty =
            BindableProperty.Create(nameof(IsMenuVisible), typeof(bool), typeof(ViewBase), false);
        public static readonly BindableProperty IsInfoVisibleProperty =
            BindableProperty.Create(nameof(IsInfoVisible), typeof(bool), typeof(ViewBase), false);
        public static readonly BindableProperty IsSearchVisibleProperty =
            BindableProperty.Create(nameof(IsSearchVisible), typeof(bool), typeof(ViewBase), false);
        public static readonly BindableProperty IsSearchExpandedProperty =
            BindableProperty.Create(nameof(IsSearchExpanded), typeof(bool), typeof(ViewBase), false);
        public static readonly BindableProperty SearchTextProperty =
            BindableProperty.Create(nameof(SearchText), typeof(string), typeof(ViewBase), string.Empty);
        public static readonly BindableProperty BackCommandProperty =
            BindableProperty.Create(nameof(BackCommand), typeof(ICommand), typeof(ViewBase));
        public static readonly BindableProperty MenuCommandProperty =
            BindableProperty.Create(nameof(MenuCommand), typeof(ICommand), typeof(ViewBase));
        public static readonly BindableProperty InfoCommandProperty =
            BindableProperty.Create(nameof(InfoCommand), typeof(ICommand), typeof(ViewBase));
        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create(nameof(SearchCommand), typeof(ICommand), typeof(ViewBase));

        public bool IsBackVisible
        {
            get
            {
                return (bool)this.GetValue(IsBackVisibleProperty);
            }
            set
            {
                this.SetValue(IsBackVisibleProperty, value);
            }
        }

        public bool IsMenuVisible
        {
            get
            {
                return (bool)this.GetValue(IsMenuVisibleProperty);
            }
            set
            {
                this.SetValue(IsMenuVisibleProperty, value);
            }
        }

        public bool IsInfoVisible
        {
            get
            {
                return (bool)this.GetValue(IsInfoVisibleProperty);
            }
            set
            {
                this.SetValue(IsInfoVisibleProperty, value);
            }
        }

        public bool IsSearchVisible
        {
            get
            {
                return (bool)this.GetValue(IsSearchVisibleProperty);
            }
            set
            {
                this.SetValue(IsSearchVisibleProperty, value);
            }
        }

        public bool IsSearchExpanded
        {
            get
            {
                return (bool)this.GetValue(IsSearchExpandedProperty);
            }
            set
            {
                this.SetValue(IsSearchExpandedProperty, value);
            }
        }

        public string SearchText
        {
            get
            {
                return (string)this.GetValue(SearchTextProperty);
            }
            set
            {
                this.SetValue(SearchTextProperty, value);
            }
        }

        public ICommand BackCommand
        {
            get
            {
                return (ICommand)this.GetValue(BackCommandProperty);
            }
            set
            {
                this.SetValue(BackCommandProperty, value);
            }
        }

        public ICommand MenuCommand
        {
            get
            {
                return (ICommand)this.GetValue(MenuCommandProperty);
            }
            set
            {
                this.SetValue(MenuCommandProperty, value);
            }
        }

        public ICommand InfoCommand
        {
            get
            {
                return (ICommand)this.GetValue(InfoCommandProperty);
            }
            set
            {
                this.SetValue(InfoCommandProperty, value);
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                return (ICommand)this.GetValue(SearchCommandProperty);
            }
            set
            {
                this.SetValue(SearchCommandProperty, value);
            }
        }

        public ViewBase()
        {
            this.BackCommand = new Command(this.OnBackCommand);
            this.SearchCommand = new Command(this.OnSearchCommand);
        }

        private void OnBackCommand()
        {
            this.Navigation.PopAsync();
        }

        private void OnSearchCommand()
        {
            this.IsSearchExpanded = !this.IsSearchExpanded;
        }
    }
}
