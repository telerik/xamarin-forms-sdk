using System;
using System.Collections.ObjectModel;
using System.Linq;
using SDKBrowser.Common;
using SDKBrowser.Services;
using Telerik.XamarinForms.DataControls.ListView.Commands;
using Xamarin.Forms;

namespace SDKBrowser.ViewModels
{
    public class CategoryViewModel : SearchViewModel
    {
        public ObservableCollection<Example> Examples { get; private set; }
        public Command<ItemTapCommandContext> NextCommand { get; private set; }

        public CategoryViewModel(Category category)
        {
            this.IsBackVisible = true;
            this.HeaderTitle = category.Title;
            this.Examples = new ObservableCollection<Example>();
            this.NextCommand = new Command<ItemTapCommandContext>(this.OnNextCommand);

            foreach (var example in category.Examples)
            {
                this.Examples.Add(example);
            }
        }

        private void OnNextCommand(ItemTapCommandContext context)
        {
            var navigationService = DependencyService.Get<INavigationService>();

            if (context.Item is Example)
            {
                navigationService.NavigateToAsync<ExampleViewModel>(context.Item);
            }
        }

        protected override bool PassesFilter(object item, params string[] tokens)
        {
            var example = (Example)item;
            var comparison = StringComparison.OrdinalIgnoreCase;

            return tokens.All(token =>
                example.Name.IndexOf(token, comparison) >= 0 ||
                example.Title.IndexOf(token, comparison) >= 0);
        }
    }
}
