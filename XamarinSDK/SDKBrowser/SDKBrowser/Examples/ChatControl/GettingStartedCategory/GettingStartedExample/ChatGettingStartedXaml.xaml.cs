using System.Collections.Specialized;
using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChatControl.GettingStartedCategory.GettingStartedExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatGettingStartedXaml : ContentView
    {
        // >> chat-getting-started-initiliaze
        private RepeatBotService botService;
        private Author botAuthor;

        public ChatGettingStartedXaml()
        {
            InitializeComponent();
            
            this.botService = new RepeatBotService();
            this.botService.AttachOnReceiveMessage(this.OnBotMessageReceived);
            this.botAuthor = new Author { Name = "botty"};

            ((INotifyCollectionChanged)this.chat.Items).CollectionChanged += ChatItems_CollectionChanged; ;
        }
        // << chat-getting-started-initiliaze
        // >> chat-getting-started-events
        private void ChatItems_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                TextMessage chatMessage = (TextMessage)e.NewItems[0];
                if (chatMessage.Author == chat.Author)
                {
                    this.botService.SendToBot(chatMessage.Text);
                }
            }
        }
        private void OnBotMessageReceived(string message)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                TextMessage textMessage = new TextMessage();
                textMessage.Data = message;
                textMessage.Author = this.botAuthor;
                textMessage.Text = message;
                chat.Items.Add(textMessage);
            });
        }
        // << chat-getting-started-events
    }
}