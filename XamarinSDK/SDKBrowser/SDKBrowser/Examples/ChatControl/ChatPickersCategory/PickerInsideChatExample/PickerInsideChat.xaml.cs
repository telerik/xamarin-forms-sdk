using System;
using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChatControl.ChatPickersCategory.PickerInsideChatExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerInsideChat : ContentView
	{
		public PickerInsideChat()
		{
			InitializeComponent ();

            // >> chat-chatpicker-overlay-code
            DatePickerContext context = new DatePickerContext
            {
                MinDate = new DateTime(2019, 1, 1),
                MaxDate = new DateTime(2019, 2, 2),
                DisplayDate = new DateTime(2019, 1, 16)
            };

            context.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "SelectedDate")
                {
                    if (context.SelectedDate != null)
                    {
                        chat.Items.Add(new TextMessage { Author = this.chat.Author, Text = "" + context.SelectedDate });
                        (chat.Picker as RadChatPicker).Context = null;
                    }
                }
            };
            (chat.Picker as RadChatPicker).Context = context;
            // << chat-chatpicker-overlay-code
        }
    }
}