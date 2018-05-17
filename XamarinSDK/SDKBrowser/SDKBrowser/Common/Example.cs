using System.Xml.Serialization;

namespace SDKBrowser.Common
{
    public class Example
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Page { get; set; }
        public string Info { get; set; }
        public string ExcludeFrom { get; set; }

        [XmlIgnore]
        public Category Category { get; set; }
    }
}
