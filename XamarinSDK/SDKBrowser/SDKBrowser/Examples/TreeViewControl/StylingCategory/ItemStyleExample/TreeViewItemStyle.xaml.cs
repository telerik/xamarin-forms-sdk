using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TreeViewControl.StylingCategory.ItemStyleExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TreeViewItemStyle : ContentView
	{
        public TreeViewItemStyle()
		{
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}