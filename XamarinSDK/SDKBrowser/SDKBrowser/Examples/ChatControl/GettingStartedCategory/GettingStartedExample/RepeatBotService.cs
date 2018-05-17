using System;
using System.Threading.Tasks;

namespace SDKBrowser.Examples.ChatControl.GettingStartedCategory.GettingStartedExample
{
    // >> chat-gettingstarted-botservice
    public class RepeatBotService
    {
        private Action<string> onReceiveMessage;
        internal void AttachOnReceiveMessage(Action<string> onMessageReceived)
        {
            this.onReceiveMessage = onMessageReceived;
        }
        internal void SendToBot(string text)
        {
            Task.Delay(500).ContinueWith(t => this.onReceiveMessage?.Invoke(text));
        }
    }
    // << chat-gettingstarted-botservice
}
