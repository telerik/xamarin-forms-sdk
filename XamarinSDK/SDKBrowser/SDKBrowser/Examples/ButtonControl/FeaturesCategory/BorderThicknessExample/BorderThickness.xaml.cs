using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ButtonControl.FeaturesCategory.BorderThicknessExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BorderThickness : ContentView
    {
        public BorderThickness()
        {
            this.InitializeComponent();
        }

        private void Apply(object sender, System.EventArgs e)
        {
            this.ApplyBorder();
        }

        private void Randomize(object sender, System.EventArgs e)
        {
            var r = new Random();
            this.left.Text = r.Next(0, 10).ToString();
            this.right.Text = r.Next(0, 10).ToString();
            this.top.Text = r.Next(0, 10).ToString();
            this.bottom.Text = r.Next(0, 10).ToString();
            this.color.SelectedIndex = r.Next(0, 3);
            this.ApplyBorder();
        }

        private void ApplyBorder()
        {
            rb.BorderColor = Color.FromHex(color.SelectedItem.ToString());
            double left, top, right, bottom;
            if (double.TryParse(this.left.Text, out left) &&
                double.TryParse(this.top.Text, out top) &&
                double.TryParse(this.right.Text, out right) &&
                double.TryParse(this.bottom.Text, out bottom))
            {
                rb.BorderThickness = new Thickness(left, top, right, bottom);
            }
        }
    }
}