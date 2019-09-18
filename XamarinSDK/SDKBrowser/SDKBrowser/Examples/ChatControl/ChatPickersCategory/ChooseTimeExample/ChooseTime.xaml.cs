using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChatControl.ChatPickersCategory.ChooseTimeExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChooseTime : ContentView
	{
		public ChooseTime ()
		{
			InitializeComponent ();

            // >> chat-chatpicker-timepicker
            TimePickerContext context = new TimePickerContext
            {
                StartTime = TimeSpan.FromHours(1),
                EndTime = TimeSpan.FromHours(5),
            };
            PickerItem pickerItem = new PickerItem { Context = context };
            chat.Items.Add(new TextMessage { Text = "Select a time" });
            chat.Items.Add(pickerItem);
            context.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "SelectedValue")
                {
                    if (context.SelectedValue != null)
                    {
                        chat.Items.Remove(pickerItem);
                        chat.Items.Add(new TextMessage { Author = chat.Author, Text = "" + context.SelectedValue });
                    }
                }
            };
            // << chat-chatpicker-timepicker
        }
    }
}