using System.Collections.Generic;

namespace SDKBrowser.Examples.ListView.ItemStyles
{
    // >> listview-itemstyles-source
    public class SourceItem
    {
        public SourceItem(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }

    public class ViewModel
    {
        public ViewModel()
        {
            this.Source = new List<SourceItem> { new SourceItem("Tom"), new SourceItem("Anna"), new SourceItem("Peter"), new SourceItem("Teodor"), new SourceItem("Lorenzo"), new SourceItem("Andrea"), new SourceItem("Martin") };
        }

        public List<SourceItem> Source { get; set; }
    }
    // << listview-itemstyles-source
}

