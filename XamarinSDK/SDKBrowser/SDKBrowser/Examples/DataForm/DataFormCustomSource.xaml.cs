using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Input.DataForm;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataForm
{
    public partial class DataFormCustomSource : ContentPage
    {
        Dictionary<string, string> source = GetData();

        public DataFormCustomSource()
        {
            InitializeComponent();

            dataForm.MetadataProvider = new CustomMetadataProvider();

            dataForm.Source = source;
        }

        private static Dictionary<string, string> GetData()
        {
            var dict = new Dictionary<string, string>();

            dict.Add("FirstName", "John");
            dict.Add("LastName", "Dow");
            dict.Add("Country", "Unknown");

            return dict;

        }

        private void CommitButtonButtonClicked(object sender, EventArgs e)
        {
            this.dataForm.FormValidationCompleted += this.DataFormValidationCompleted;
            this.dataForm.CommitAll();
        }

        private async void DataFormValidationCompleted(object sender, FormValidationCompletedEventArgs e)
        {
            this.dataForm.FormValidationCompleted -= this.DataFormValidationCompleted;
            if (e.IsValid)
            {
                await this.DisplayAlert("Success", "Book was successfully updated.", "OK");
            }
            else
            {
                await this.DisplayAlert("Fail", string.Format("There are some invalid fields."), "OK");
            }
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

    public class CustomMetadataProvider : PropertyMetadataProviderBase
    {
        private List<IEntityProperty> entityProperties = new List<IEntityProperty>();

        public override List<IEntityProperty> EntityProperties
        {
            get
            {
                return entityProperties;
            }
        }

        public override void Initialize(object source)
        {
            var data = source as Dictionary<string, string>;

            foreach (var item in data)
            {
                var metadata = new EntityPropertyMetadata() { Header = item.Key };
                var property = new CustomEntityProperty(item.Key, data, metadata);
                this.entityProperties.Add(property);
            }
        }
    }

    public class CustomEntityProperty : IEntityProperty
    {
        private Dictionary<string, string> dataItem;

        public CustomEntityProperty(string propertyName, Dictionary<string, string> item, EntityPropertyMetadata metadata)
        {
            this.PropertyName = propertyName;
            this.PropertyType = typeof(string);
            this.Metadata = metadata;
            this.dataItem = item;
            this.IsReadOnly = false;
        }

        public object OriginalValue
        {
            get
            {
                return this.dataItem[this.PropertyName];
            }
        }

        public Type PropertyType { get; }

        public EntityPropertyMetadata Metadata { get; }

        public object DataItem { get { return this.dataItem; } }

        public string PropertyName { get; }

        public object PropertyValue { get; set; }

        public bool IsReadOnly { get; }

        public void Commit()
        {
            this.dataItem[this.PropertyName] = (string)this.PropertyValue;
        }
    }
}
