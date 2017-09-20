using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.MaskedInput
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Commands : ContentPage
    {
        public Commands()
        {
            InitializeComponent();

            // >>  maskedinput-features-commands-applymaskstarted-added
            this.input.Commands.Add(new CustomBeforeTextMaskedCommand());
            // <<  maskedinput-features-commands-applymaskstarted-added

            // >>  maskedinput-features-commands-applymaskfinished-added
            this.input.Commands.Add(new CustomAfterTextMaskedCommand());
            // <<  maskedinput-features-commands-applymaskfinished-added
        }
    }
   
}