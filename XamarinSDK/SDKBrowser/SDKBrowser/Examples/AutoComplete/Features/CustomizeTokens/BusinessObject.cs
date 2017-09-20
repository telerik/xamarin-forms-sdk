using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKBrowser.Examples.AutoComplete.Features.CustomizeTokens
{
    public class BusinessObject
    {
        public BusinessObject(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}