using System.Collections.Generic;
using System.Xml.Serialization;

namespace SDKBrowser.Common
{
    public class Category
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string ExcludeFrom { get; set; }

        [XmlIgnore]
        public Control Control { get; set; }
        public List<Example> Examples { get; set; }

        public Category()
        {
            this.Examples = new List<Example>();
        }
    }
}
