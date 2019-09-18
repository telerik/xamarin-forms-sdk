using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChatControl.HowToCategory.CustomCardExample
{
    public class MyCardPickerTemplateSelector : CardPickerTemplateSelector
    {
        public DataTemplate MyCardTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            MyCardContext myCard = item as MyCardContext;
            if (myCard != null)
            {
                return this.MyCardTemplate;
            }

            return base.OnSelectTemplate(item, container);
        }
    }
}
