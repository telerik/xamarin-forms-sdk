using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
