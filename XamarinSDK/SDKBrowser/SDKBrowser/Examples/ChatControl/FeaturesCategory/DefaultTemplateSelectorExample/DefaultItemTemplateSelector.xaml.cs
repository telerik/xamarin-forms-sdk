using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChatControl.FeaturesCategory.DefaultTemplateSelectorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DefaultItemTemplateSelector : ContentView
    {
        public DefaultItemTemplateSelector()
        {
            InitializeComponent();

            var botAuthor = new Author { Name = "botty" };

            this.chat.Items.Add(new TextMessage() { Text = "Hi.", Author = botAuthor});
            this.chat.Items.Add(new TextMessage() { Text = "How can I help you?", Author = botAuthor });
        }
    }
}