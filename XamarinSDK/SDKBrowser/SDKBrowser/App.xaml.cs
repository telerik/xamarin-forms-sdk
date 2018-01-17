using SDKBrowser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ExamplesLoader loader = new ExamplesLoader("SDKBrowser.Common.Examples.xml");

            this.MainPage = new NavigationPage(new RootPage(loader));
        }
    }
}