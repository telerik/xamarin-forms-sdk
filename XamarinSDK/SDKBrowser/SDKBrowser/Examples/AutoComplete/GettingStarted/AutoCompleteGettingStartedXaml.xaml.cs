using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SDKBrowser.Examples.AutoComplete
{
    public partial class AutoCompleteGettingStartedXaml : ContentPage
    {
        public AutoCompleteGettingStartedXaml()
        {
            InitializeComponent();

            //>> autocomplete-getting-started-items-source
            this.autoComplete.ItemsSource = new List<string>()
            {
                "Freda Curtis",
                "Jeffery Francis",
                "Eva Lawson",
                "Emmett Santos",
                "Theresa Bryan",
                "Jenny Fuller",
                "Terrell Norris",
                "Eric Wheeler",
                "Julius Clayton",
                "Alfredo Thornton",
                "Roberto Romero",
                "Orlando Mathis",
                "Eduardo Thomas",
                "Harry Douglas",
                "Parker Blanton",
                "Leanne Motton",
                "Shanti Osborn",
                "Merry Lasker",
                "Jess Doyon",
                "Kizzie Arjona",
                "Augusta Hentz",
                "Tasha Trial",
                "Fredda Boger",
                "Megan Mowery",
                "Hong Telesco",
                "Inez Landi",
                "Taina Cordray",
                "Shantel Jarrell",
                "Soo Heidt",
                "Rayford Mahon",
                "Jenny Omarah",
                "Denita Dalke",
                "Nida Carty",
                "Sharolyn Lambson",
                "Niki Samaniego",
                "Rudy Jankowski",
                "Matha Whobrey",
                "Jessi Knouse",
                "Vena Rieser",
                "Roosevelt Boyce",
                "Kristan Swiney",
                "Lauretta Pozo",
                "Jarvis Victorine",
                "Dane Gabor"
            };
            //<< autocomplete-getting-started-items-source
        }
    }
}
