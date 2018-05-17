using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.DataFormControl.SourceCategory.CustomSourceExample
{
    public partial class DataFormCustomSource : ContentView
    {
        Dictionary<string, string> source = GetData();

        public DataFormCustomSource()
        {
            this.InitializeComponent();

            // >> dataform-source-customsource-dataform-setup
            dataForm.MetadataProvider = new CustomMetadataProvider();
            dataForm.Source = source;
            // << dataform-source-customsource-dataform-setup

            dataForm.CommitMode = CommitMode.Immediate;
        }

        private static Dictionary<string, string> GetData()
        {
            // >> dataform-source-customsource-source
            var source = new Dictionary<string, string>();

            source.Add("FirstName", "John");
            source.Add("LastName", "Dow");
            source.Add("Country", "Unknown");
            // << dataform-source-customsource-source

            return source;
        }

        private void GetSourceProperties(object sender, EventArgs e)
        {
            sourceProperties.Children.Clear();
            foreach (var property in this.source)
            {
                var stack = new StackLayout { Orientation = StackOrientation.Horizontal };
                stack.Children.Add(new Label { Text = property.Key, FontAttributes = FontAttributes.Bold });
                stack.Children.Add(new Label { Text = property.Value });
                sourceProperties.Children.Add(stack);
            }
        }
    }
}
