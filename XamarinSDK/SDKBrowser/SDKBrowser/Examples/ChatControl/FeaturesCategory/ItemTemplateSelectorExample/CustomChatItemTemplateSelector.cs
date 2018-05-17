using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChatControl.FeaturesCategory.ItemTemplateSelectorExample
{
    public class CustomChatItemTemplateSelector : ChatItemTemplateSelector
    {
        public DataTemplate ImportantMessageTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            ChatItem chatItem = item as ChatItem;
            var myItem = chatItem?.Data as SimpleChatItem;
            if (myItem != null && myItem.Category == MessageCategory.Important)
            {
                return this.ImportantMessageTemplate;
            }
            return base.OnSelectTemplate(item, container);
        }
    }
}
