using System;
using Telerik.XamarinForms.ConversationalUI;

namespace SDKBrowser.Examples.ChatControl.HowToCategory.CustomCardExample
{
    public class MyCardContext : CardContext
    {
        private DateTime _date;
        public DateTime Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this.UpdateValue(ref this._date, value);
            }
        }

        private string _contactDetails;
        public string ContactDetails
        {
            get
            {
                return this._contactDetails;
            }
            set
            {
                this.UpdateValue(ref this._contactDetails, value);
            }
        }
    }
}
