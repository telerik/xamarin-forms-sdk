using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory
{
    // >> autocompleteview-features-businessobject
    public class Client
    {
        public Client(string name, string email, string imageSource)
        {
            this.Name = name;
            this.Email = email;
            this.ImageSource = imageSource;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ImageSource { get; set; }
    }
    // << autocompleteview-features-businessobject
}
