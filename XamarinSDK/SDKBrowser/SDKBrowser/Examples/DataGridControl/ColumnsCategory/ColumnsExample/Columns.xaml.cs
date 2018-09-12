using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.ColumnsCategory.ColumnsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Columns : ContentView
    {
        public Columns()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}