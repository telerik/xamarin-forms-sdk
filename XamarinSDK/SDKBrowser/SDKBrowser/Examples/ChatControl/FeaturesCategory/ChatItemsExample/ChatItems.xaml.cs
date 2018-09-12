using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChatControl.FeaturesCategory.ChatItemsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatItems : ContentView
    {
        public ChatItems()
        {
            InitializeComponent();

            var bot = new Author() { Name = "botty" };
            // >> chat-chatitems-timebreak
            chat.Items.Add(new TextMessage { Author = bot, Text = "Hello there" });
            chat.Items.Add(new TimeBreak() { Text = "Unread" });
            chat.Items.Add(new TextMessage() { Author = bot, Text = "How are you today?"});
            // << chat-chatitems-timebreak
        }
    }
}