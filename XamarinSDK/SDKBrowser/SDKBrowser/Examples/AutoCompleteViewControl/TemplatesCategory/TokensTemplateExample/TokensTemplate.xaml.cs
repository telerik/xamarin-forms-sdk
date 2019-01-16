using SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.TokensExample;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.TemplatesCategory.TokensTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TokensTemplate : ContentView
    {
        public TokensTemplate ()
        {
            InitializeComponent ();
            this.BindingContext = new TokensViewModel();
        }
        // >> autocompleteview-templates-token-template-labelgesture
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var closeLabel = sender as Label;
            if (closeLabel != null)
            {
                var item = closeLabel.BindingContext as City;
                if (item != null)
                {
                    this.autoCompleteViewTokensTemplate.Tokens.Remove(item);
                }
            }
        }
        // << autocompleteview-templates-token-template-labelgesture
    }
}