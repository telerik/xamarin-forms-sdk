using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ListPickerControl.GettingStartedCategory.GettingStartedExample
{
    // >> listpicker-getting-started-viewmodel
    public class ViewModel
    {
        public ViewModel()
        {
            this.Items = new ObservableCollection<Person>()
            {
                new Person("Freda","Curtis"),
                new Person("Jeffery","Francis"),
                new Person("Ema","Lawson"),
                new Person("Niki","Samaniego"),
                new Person("Jenny","Santos"),
                new Person("Eric","Wheeler"),
                new Person("Emmett","Fuller"),
                new Person("Brian","Johnas"),
            };
        }

        public ObservableCollection<Person> Items { get; set; }
    }
    // << listpicker-getting-started-viewmodel
}
