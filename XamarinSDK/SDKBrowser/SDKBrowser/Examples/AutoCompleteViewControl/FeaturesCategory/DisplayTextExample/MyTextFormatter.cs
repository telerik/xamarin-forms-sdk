using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Input.AutoCompleteView;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.DisplayTextExample
{
    // >> autocompleteview-features-text-formatter-plain-class
    public class MyTextFormatter : IDisplayTextFormatter
    {
        public string FormatItem(object item)
        {
            var businessItem = item as Client;
            return string.Format("Name: {0}, Email: {1}", businessItem.Name, businessItem.Email);
        }
    }
    // << autocompleteview-features-text-formatter-plain-class
}

