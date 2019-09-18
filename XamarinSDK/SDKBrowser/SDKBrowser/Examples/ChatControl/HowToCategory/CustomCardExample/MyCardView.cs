using System;
using Xamarin.Forms;
using Telerik.XamarinForms.ConversationalUI;

namespace SDKBrowser.Examples.ChatControl.HowToCategory.CustomCardExample
{
    public class MyCardView : CardView
    {
        public static readonly BindableProperty DateProperty =
           BindableProperty.Create(nameof(Date), typeof(DateTime), typeof(MyCardView));

        public static readonly BindableProperty ContactDetailsProperty =
           BindableProperty.Create(nameof(ContactDetails), typeof(string), typeof(MyCardView));

        private static readonly ControlTemplate controlTemplate;

        static MyCardView()
        {
            MyCardViewResourceDictionary resources = new MyCardViewResourceDictionary();
            controlTemplate = (ControlTemplate)resources["MyCardView_ControlTemplate"];
        }

        public MyCardView()
        {
            this.Template = controlTemplate;
        }

        public DateTime Date
        {
            get
            {
                return (DateTime)this.GetValue(DateProperty);
            }
            set
            {
                this.SetValue(DateProperty, value);
            }
        }

        public string ContactDetails
        {
            get
            {
                return (string)this.GetValue(ContactDetailsProperty);
            }
            set
            {
                this.SetValue(ContactDetailsProperty, value);
            }
        }
    }
}
