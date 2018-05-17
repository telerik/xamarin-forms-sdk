using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChatControl.FeaturesCategory.ItemTemplateSelectorExample
{
    public class ViewModel : NotifyPropertyChangedBase
    {
        private Author me;
        public ViewModel()
        {          
           string suffix = Device.RuntimePlatform == Device.UWP ? "Assets/" : null;

            this.Me = new Author() { Name = "human", Avatar = suffix + "sampleAvatar.png" };
            this.Bot = new Author() { Name = "Bot", Avatar = suffix + "sampleBot.png" };

            // >> chat-features-itemtemplate-items
            this.Items = new ObservableCollection<SimpleChatItem>();

            // Simulate async data loading
            Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
            {
                this.Items.Add(new SimpleChatItem { Author = this.Bot, Text = "Hi.", Category = MessageCategory.Normal });
                this.Items.Add(new SimpleChatItem { Author = this.Bot, Text = "Please check our new privacy policy here:...", Category = MessageCategory.Important });
                return false;
            });
            // << chat-features-itemtemplate-items
        }
        public Author Me
        {
            get
            {
                return this.me;
            }
            set
            {
                if (this.me != value)
                {
                    this.me = value;
                    this.OnPropertyChanged(nameof(this.Me));
                }
            }
        }
        public Author Bot { get; set; }
        public IList<SimpleChatItem> Items { get; set; }
    }
}
