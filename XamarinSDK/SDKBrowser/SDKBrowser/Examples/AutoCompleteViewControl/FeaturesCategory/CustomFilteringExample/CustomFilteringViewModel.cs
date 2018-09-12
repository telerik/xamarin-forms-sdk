using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.CustomFilteringExample
{
    // >> autocompleteview-filering-viewmodel
    public class CustomFilteringViewModel
    {
        public CustomFilteringViewModel()
        {
            this.Source = new ObservableCollection<Person>()
            {
                new Person("Freda", "Curtis"),
                new Person("Jeffery", "Francis"),
                new Person("Eva", "Lawson"),
                new Person("Emmett", "Santos"),
                new Person("Theresa", "Bryan"),
                new Person("Terrell", "Norris"),
                new Person("Eric", "Wheeler"),
                new Person("Alfredo", "Thornton"),
                new Person("Roberto", "Romero"),
                new Person("Orlando", "Mathis"),
                new Person("Eduardo", "Thomas"),
                new Person("Harry", "Douglas"),
                new Person("Merry", "Lasker")
            };

            this.Filter = new CustomAutoCompleteViewFilter();
        }

        public ObservableCollection<Person> Source { get; set; }

        public CustomAutoCompleteViewFilter Filter { get; set; }
    }
    // << autocompleteview-filering-viewmodel
}

