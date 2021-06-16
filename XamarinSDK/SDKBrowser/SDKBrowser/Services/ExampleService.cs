using System;
using SDKBrowser.Common;
using Xamarin.Essentials;

namespace SDKBrowser.Services
{
    public class ExampleService : IExampleService
    {
        private const string NameFormat = "SDKBrowser.Examples.{0}Control.{1}Category.{2}Example.{3}";
        private const string UrlFormat = "{0}/Examples/{1}Control/{2}Category/{3}Example";

        public object CreateExample(Example example)
        {
            var category = example.Category;
            var control = category.Control;
            var name = string.Format(NameFormat,
                control.Name, category.Name,
                example.Name, example.Page);
            var type = Type.GetType(name);

            return Activator.CreateInstance(type);
        }

        public void OpenExample(Example example)
        {
            var category = example.Category;
            var control = category.Control;
            var configuration = control.Configuration;
            var url = string.Format(UrlFormat,
                configuration.SourceUrl, control.Name,
                category.Name, example.Name);
            var uri = new Uri(url);

            Launcher.OpenAsync(uri);
        }
    }
}
