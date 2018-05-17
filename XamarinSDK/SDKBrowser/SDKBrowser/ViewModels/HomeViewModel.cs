using System;
using System.Collections.ObjectModel;
using System.Linq;
using SDKBrowser.Common;
using SDKBrowser.Services;
using Telerik.XamarinForms.DataControls.ListView.Commands;
using Xamarin.Forms;

namespace SDKBrowser.ViewModels
{
    public class HomeViewModel : SearchViewModel
    {
        public ObservableCollection<Control> Controls { get; private set; }
        public ObservableCollection<Example> Examples { get; private set; }
        public Command<ItemTapCommandContext> NextCommand { get; private set; }

        public HomeViewModel()
        {
            var configurationService = DependencyService.Get<IConfigurationService>();
            var configuration = configurationService.Configuration;

            this.HeaderTitle = configuration.HeaderTitle;
            this.HeaderIcon = configuration.HeaderIcon;
            this.Controls = new ObservableCollection<Control>();
            this.Examples = new ObservableCollection<Example>();
            this.NextCommand = new Command<ItemTapCommandContext>(this.OnNextCommand);

            foreach (var control in configuration.Controls)
            {
                this.Controls.Add(control);

                foreach (var category in control.Categories)
                {
                    foreach (var example in category.Examples)
                    {
                        this.Examples.Add(example);
                    }
                }
            }
        }

        private void OnNextCommand(ItemTapCommandContext context)
        {
            var navigationService = DependencyService.Get<INavigationService>();

            var control = context.Item as Control;

            if (control != null)
            {
                if (control.Categories.Count > 1)
                {
                    navigationService.NavigateToAsync<ControlViewModel>(control);
                }
                else if (control.Categories.Count > 0)
                {
                    var category = control.Categories[0];

                    if (category.Examples.Count > 1)
                    {
                        navigationService.NavigateToAsync<CategoryViewModel>(category);
                    }
                    else if (category.Examples.Count > 0)
                    {
                        var example = category.Examples[0];

                        navigationService.NavigateToAsync<ExampleViewModel>(example);
                    }
                }
            }
            else
            {
                var example = context.Item as Example;

                if (example != null)
                {
                    navigationService.NavigateToAsync<ExampleViewModel>(example);
                }
            }
        }

        protected override bool PassesFilter(object item, params string[] tokens)
        {
            var example = (Example)item;
            var category = example.Category;
            var control = category.Control;
            var comparison = StringComparison.OrdinalIgnoreCase;

            return tokens.All(token =>
                example.Name.IndexOf(token, comparison) >= 0 ||
                example.Title.IndexOf(token, comparison) >= 0 ||
                control.Name.IndexOf(token, comparison) >= 0 ||
                control.Title.IndexOf(token, comparison) >= 0);
        }

        protected override object ExtractGroup(object item)
        {
            var example = (Example)item;
            var category = example.Category;
            var control = category.Control;

            return control.Title;
        }
    }
}
