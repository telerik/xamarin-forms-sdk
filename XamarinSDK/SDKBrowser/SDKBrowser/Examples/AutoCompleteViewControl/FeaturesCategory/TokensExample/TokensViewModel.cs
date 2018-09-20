using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.TokensExample
{
    // >> autocompleteview-tokens
    public class TokensViewModel
    {
        public List<City> Source { get; set; }
        public TokensViewModel()
        {
            this.Source = new List<City>()
              {
                  new City("Madrid"),
                  new City("Paris"),
                  new City("Barcelona"),
                  new City("New York"),
                  new City("Budapest"),
                  new City("Sofia"),
                  new City("Palermo"),
                  new City("Melbourne"),
                  new City("London"),
                  new City("Nagoya"),
                  new City("Tokyo"),
                  new City("Atlanta"),
                  new City("Toronto"),
                  new City("Athens"),
              };
        }
    }
    // << autocompleteview-tokens
}
