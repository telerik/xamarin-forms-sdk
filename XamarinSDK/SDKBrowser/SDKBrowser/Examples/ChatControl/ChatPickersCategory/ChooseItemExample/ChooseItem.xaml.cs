using System.Collections.Generic;
using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChatControl.ChatPickersCategory.ChooseItemExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChooseItem : ContentView
	{
		public ChooseItem ()
		{
			InitializeComponent ();

            // >> chat-chatpicker-itempicker
            ItemPickerContext context = new ItemPickerContext
            {
                ItemsSource = new List<string>() { "2 days", "5 days", "7 days", "Another period" }
            };
            PickerItem pickerItem = new PickerItem { Context = context, HeaderText = "Select an item" };

            chat.Items.Add(pickerItem);
            context.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "SelectedItem")
                {
                    if (context.SelectedItem != null)
                    {
                        chat.Items.Remove(pickerItem);
                        chat.Items.Add(new TextMessage { Author = chat.Author, Text = "" + context.SelectedItem });
                    }
                }
            };
            // << chat-chatpicker-itempicker
        }
    }
}