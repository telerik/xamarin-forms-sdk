using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.EntryExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Events : ContentPage
    {
        public Events()
        {
            InitializeComponent();
            this.entry.TextChanged += Entry_TextChanged;
            this.entry.Completed += Entry_Completed;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            this.textChangedLabel.Text = "User completed entering text";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.textChangedLabel.Text = $"Text changed from {e.OldTextValue} to {e.NewTextValue}";
        }
    }
}