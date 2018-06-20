using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CheckBoxControl.FeaturesCategory.ColorChangingExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ColorChanging : ContentView
	{
		public ColorChanging ()
		{
			InitializeComponent ();
		}

        // >> checkbox-colorchanging-clickecdischecked-csharp
        public void Clicked(object sender, EventArgs e)
        {
            this.checkbox.IsChecked = null;
        }
        // << checkbox-colorchanging-clickecdischecked-csharp
    }
}