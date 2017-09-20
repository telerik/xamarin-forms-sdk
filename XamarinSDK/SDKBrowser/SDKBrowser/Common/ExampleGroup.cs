using System.Collections.Generic;

namespace SDKBrowser.Common
{
    public class ExampleGroup
    {
        public string Name { get; set; }
        public List<Example> Examples { get; set; }

        public ExampleGroup()
        {
            this.Examples = new List<Example>();
        }

        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
}
