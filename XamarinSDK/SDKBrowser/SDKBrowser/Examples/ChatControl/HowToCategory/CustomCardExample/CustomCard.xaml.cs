using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChatControl.HowToCategory.CustomCardExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomCard : ContentView
	{
		public CustomCard ()
		{
			InitializeComponent();

            PickerItem pickerItem = new PickerItem();
            var context = new CardPickerContext { Cards = this.GetCards(pickerItem) };
            pickerItem.Context = context;
            chat.Items.Add(new TextMessage { Text = "Select a contact" });
            chat.Items.Add(pickerItem);
        }

        private IEnumerable<CardContext> GetCards(ChatItem chatItem)
        {
            List<CardContext> cards = new List<CardContext>()
            {
                new MyCardContext() { Date=DateTime.Today, ContactDetails="John Doe", Actions = GetActions(chatItem, "John")},
                new MyCardContext() { Date=DateTime.Today.AddDays(10), ContactDetails="Linda Jones", Actions=GetActions(chatItem, "Linda")}
            };
            return cards;
        }

        private ICollection<CardActionContext> GetActions(ChatItem chatItem, string Title)
        {
            var selectAction = new CardActionContext
            {
                Text = "Select",
                Command = new Command(() =>
                {
                    var index = chat.Items.IndexOf(chatItem);
                    chat.Items.RemoveAt(index);
                    chat.Items.Add(new TextMessage { Author = this.chat.Author, Text = Title });
                })
            };

            var seeBioAction = new CardActionContext
            {
                Text = "See Bio",
                Command = new Command(() =>
                {
                    var index = chat.Items.IndexOf(chatItem);
                    chat.Items.RemoveAt(index);
                    chat.Items.Add(new TextMessage { Author = this.chat.Author, Text = Title + " biography" });
                })
            };

            return new List<CardActionContext>() { selectAction, seeBioAction };
        }
    }
}