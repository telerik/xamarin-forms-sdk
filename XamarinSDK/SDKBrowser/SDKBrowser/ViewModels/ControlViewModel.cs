using System;
using System.Collections.ObjectModel;
using System.Linq;
using SDKBrowser.Common;
using SDKBrowser.Services;
using Telerik.XamarinForms.DataControls.ListView.Commands;
using Xamarin.Forms;

namespace SDKBrowser.ViewModels
{
    public class ControlViewModel : SearchViewModel
    {
        public ObservableCollection<Category> Categories { get; private set; }
        public ObservableCollection<Example> Examples { get; private set; }
        public Command<ItemTapCommandContext> NextCommand { get; private set; }

        public ControlViewModel(Control control)
        {
            this.IsBackVisible = true;
            this.HeaderTitle = control.Title;
            this.Categories = new ObservableCollection<Category>();
            this.Examples = new ObservableCollection<Example>();
            this.NextCommand = new Command<ItemTapCommandContext>(this.OnNextCommand);

            foreach (var category in control.Categories)
            {
                this.Categories.Add(category);

                foreach (var example in category.Examples)
                {
                    this.Examples.Add(example);
                }
            }
        }

        private void OnNextCommand(ItemTapCommandContext context)
        {
            var navigationService = DependencyService.Get<INavigationService>();

            var category = context.Item as Category;

            if (category != null)
            {
                if (category.Examples.Count > 1)
                {
                    navigationService.NavigateToAsync<CategoryViewModel>(category);
                }
                else if(category.Examples.Count > 0)
                {
                    var example = category.Examples[0];

                    navigationService.NavigateToAsync<ExampleViewModel>(example);
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
            var comparison = StringComparison.OrdinalIgnoreCase;

            return tokens.All(token =>
                example.Name.IndexOf(token, comparison) >= 0 ||
                example.Title.IndexOf(token, comparison) >= 0 ||
                category.Name.IndexOf(token, comparison) >= 0 ||
                category.Title.IndexOf(token, comparison) >= 0);
        }

        protected override object ExtractGroup(object item)
        {
            var example = (Example)item;
            var category = example.Category;

            return category.Title;
        }
    }
}
