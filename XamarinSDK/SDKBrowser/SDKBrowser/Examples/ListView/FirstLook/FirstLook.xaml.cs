using System;
using System.Linq;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListView
{
    public partial class FirstLook : ContentPage
    {
        public FirstLook()
        {
            InitializeComponent();
            this.BindingContext = new FirstLookViewModel();
        }
    }
}