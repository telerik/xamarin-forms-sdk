using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Telerik.XamarinForms.ConversationalUI;

namespace SDKBrowser.Examples.ChatControl.FeaturesCategory.CustomizationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Customization : ContentView
    {
        Author bot;

        public Customization()
        {
            InitializeComponent();

            string prefix = Device.RuntimePlatform == Device.UWP ? "Assets/" : null;
            string botAvatar = prefix + "sampleBot.png";
            this.bot = new Author { Name = "bot", Avatar = botAvatar, };

            this.chat1.Items.Add(new TextMessage { Text = "Hello! I am a sophisticated combination of algorithms, AI, machine learning, and large datasets. How may I be of service?", Author = bot, });
            this.chat1.Items.Add(new TextMessage { Text = "I wanted to boil an egg in my microwave, but it exploded. Why?", Author = this.chat1.Author, });
        }
    }
}