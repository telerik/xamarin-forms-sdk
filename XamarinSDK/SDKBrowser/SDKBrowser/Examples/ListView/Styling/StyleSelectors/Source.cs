using System.Collections.Generic;

namespace SDKBrowser.Examples.ListView.Styling.StyleSelectors
{
    // >> listview-gettingstarted-source
    public class SourceItem
    {
        public SourceItem(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class ViewModel
    {
        public ViewModel()
        {
            this.Source = new List<SourceItem> {
                new SourceItem("Tom", 25),
                new SourceItem("Anna",18),
                new SourceItem("Peter",43),
                new SourceItem("Teodor",29),
                new SourceItem("Lorenzo",65),
                new SourceItem("Andrea",79),
                new SourceItem("Martin",5) };
        }

        public List<SourceItem> Source { get; set; }
    }
    // << listview-gettingstarted-source
}

