using System.Collections.Generic;

namespace SDKBrowser.Examples.AutoCompleteControl.FeaturesCategory.ClearButtonVisibilityExample
{
    public class BusinessObject
    {
        public BusinessObject(string name, string imageSource)
        {
            this.Name = name;
            this.ImageSource = imageSource;
        }

        public string Name { get; set; }

        public string ImageSource { get; set; }
    }

    public class ViewModel
    {
        public ViewModel()
        {
            this.Source = new List<BusinessObject>()
            {
                new BusinessObject("Freda Curtis", "available32.png"),
                new BusinessObject("Jeffery Francis", "away32.png"),
                new BusinessObject("Eva Lawson", "available32.png"),
                new BusinessObject("Emmett Santos", "away32.png"),
                new BusinessObject("Theresa Bryan", "away32.png"),
                new BusinessObject("Jenny Fuller", "available32.png"),
                new BusinessObject("Terrell Norris", "away32.png"),
                new BusinessObject("Eric Wheeler", "busy32.png"),
                new BusinessObject("Julius Clayton", "available32.png"),
                new BusinessObject("Alfredo Thornton", "busy32.png"),
                new BusinessObject("Roberto Romero", "busy32.png"),
                new BusinessObject("Orlando Mathis", "available32.png"),
                new BusinessObject("Eduardo Thomas", "away32.png"),
                new BusinessObject("Harry Douglas", "available32.png"),
                new BusinessObject("Parker Blanton", "available32.png"),
                new BusinessObject("Leanne Motton", "busy32.png"),
                new BusinessObject("Shanti Osborn", "available32.png"),
                new BusinessObject("Merry Lasker", "busy32.png"),
                new BusinessObject("Jess Doyon", "away32.png"),
                new BusinessObject("Kizzie Arjona", "busy32.png"),
                new BusinessObject("Augusta Hentz", "available32.png"),
                new BusinessObject("Tasha Trial", "away32.png"),
                new BusinessObject("Fredda Boger", "busy32.png"),
                new BusinessObject("Megan Mowery", "available32.png"),
                new BusinessObject("Hong Telesco", "away32.png"),
                new BusinessObject("Inez Landi", "busy32.png"),
                new BusinessObject("Taina Cordray", "available32.png"),
                new BusinessObject("Shantel Jarrell", "busy32.png"),
                new BusinessObject("Soo Heidt", "available32.png"),
                new BusinessObject("Rayford Mahon", "away32.png"),
                new BusinessObject("Jenny Omarah", "away32.png"),
                new BusinessObject("Denita Dalke", "available32.png"),
                new BusinessObject("Nida Carty", "available32.png"),
                new BusinessObject("Sharolyn Lambson", "away32.png"),
                new BusinessObject("Niki Samaniego", "available32.png"),
                new BusinessObject("Rudy Jankowski", "away32.png"),
                new BusinessObject("Matha Whobrey", "busy32.png"),
                new BusinessObject("Jessi Knouse", "available32.png"),
                new BusinessObject("Vena Rieser", "away32.png"),
                new BusinessObject("Roosevelt Boyce", "available32.png"),
                new BusinessObject("Kristan Swiney", "away32.png"),
                new BusinessObject("Lauretta Pozo", "busy32.png"),
                new BusinessObject("Jarvis Victorine", "away32.png"),
                new BusinessObject("Dane Gabor", "busy32.png")
            };
        }

        public List<BusinessObject> Source { get; set; }
    }
}
