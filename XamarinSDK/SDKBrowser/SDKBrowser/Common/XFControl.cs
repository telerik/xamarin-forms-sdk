using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SDKBrowser.Common
{
    public class XFControl
    {
        public string Name { get; set; }
        public string ExcludeFrom { get; set; }
        public List<Example> Examples { get; set; }

        public XFControl()
        {
            Examples = new List<Example>();
        }
    }
}