using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKBrowser.Examples.AutoComplete.Features.CustomizeTokens
{
    public class CustomizeTokensViewModel
    {
        public CustomizeTokensViewModel()
          {
              this.Source = new List<BusinessObject>()
              {
                  new BusinessObject("Freda Curtis"),
                  new BusinessObject("Jeffery Francis"),
                  new BusinessObject("Eva Lawson"),
                  new BusinessObject("Emmett Santos"),
                  new BusinessObject("Theresa Bryan"),
                  new BusinessObject("Jenny Fuller"),
                  new BusinessObject("Terrell Norris"),
                  new BusinessObject("Eric Wheeler"),
                  new BusinessObject("Julius Clayton"),
                  new BusinessObject("Alfredo Thornton"),
                  new BusinessObject("Roberto Romero"),
                  new BusinessObject("Orlando Mathis"),
                  new BusinessObject("Eduardo Thomas"),
                  new BusinessObject("Harry Douglas"),
                  new BusinessObject("Parker Blanton"),
                  new BusinessObject("Leanne Motton"),
                  new BusinessObject("Shanti Osborn"),
                  new BusinessObject("Merry Lasker"),
                  new BusinessObject("Jess Doyon"),
                  new BusinessObject("Kizzie Arjona"),
                  new BusinessObject("Augusta Hentz"),
                  new BusinessObject("Tasha Trial"),
                  new BusinessObject("Fredda Boger"),
                  new BusinessObject("Megan Mowery"),
                  new BusinessObject("Hong Telesco"),
                  new BusinessObject("Inez Landi"),
                  new BusinessObject("Taina Cordray"),
                  new BusinessObject("Shantel Jarrell"),
                  new BusinessObject("Soo Heidt"),
                  new BusinessObject("Rayford Mahon"),
                  new BusinessObject("Jenny Omarah"),
                  new BusinessObject("Denita Dalke"),
                  new BusinessObject("Nida Carty"),
                  new BusinessObject("Sharolyn Lambson"),
                  new BusinessObject("Niki Samaniego"),
                  new BusinessObject("Rudy Jankowski"),
                  new BusinessObject("Matha Whobrey"),
                  new BusinessObject("Jessi Knouse"),
                  new BusinessObject("Vena Rieser"),
                  new BusinessObject("Roosevelt Boyce"),
                  new BusinessObject("Kristan Swiney"),
                  new BusinessObject("Lauretta Pozo"),
                  new BusinessObject("Jarvis Victorine"),
                  new BusinessObject("Dane Gabor")
              };
          }
          public List<BusinessObject> Source { get; set; }
    }
}
