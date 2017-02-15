using SDKBrowser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;


namespace SDKBrowser
{
    public class App : Application
    {
		public App()
		{
            ExamplesLoader loader = new ExamplesLoader("SDKBrowser.Common.Examples.xml");

            this.MainPage = new NavigationPage(new RootPage(loader));
		}
    }
}
