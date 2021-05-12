using System.Collections.Generic;

namespace SDKBrowser.Examples.BadgeViewControl.FeaturesCategory.BadgeViewIntegrationExample
{
    // >> badge-integration-viewmodel
    public class Book
    {
        public string Title { get; set; }

        public string Info { get; set; }
    }

    public class ViewModel
    {
        public ViewModel()
        {
            this.Source = new List<Book>{
                new Book{ Title = "The Fault in Our Stars ",  Info = "10"},
                new Book{ Title = "Divergent",  Info = "15"},
                new Book{ Title = "Gone Girl",  Info = "12" },
                new Book{ Title = "Clockwork Angel",  Info = "22" },
                new Book{ Title = "The Martian",  Info = "16"},
                new Book{ Title = "Ready Player One",  Info = "18"},
                new Book{ Title = "The Lost Hero",  Info = "32",}
            };
        }

        public List<Book> Source { get; set; }
    }
    // << badge-integration-viewmodel
}
