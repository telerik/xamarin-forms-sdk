using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChatControl.FeaturesCategory.TypingIndicatorExample
{
    // >> chat-typingindicator-itemssource-viewmodel
    public class ViewModel
    {
        public ViewModel()
        {
            var author1 = new Participant { ID = 1, ShortName = "Sandra", IsAdmin = true };
            var author2 = new Participant { ID = 2, ShortName = "John" };
            var author3 = new Participant { ID = 3, ShortName = "Billy" };

            this.TypingParticipants = new ObservableCollection<Participant>();

            Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
            {
                this.TypingParticipants.Add(author1);
                this.TypingParticipants.Add(author2);
                this.TypingParticipants.Add(author3);
                return false;
            });       
        }
        public IList<Participant> TypingParticipants { get; set; }      
    }
    // << chat-typingindicator-itemssource-viewmodel
}
