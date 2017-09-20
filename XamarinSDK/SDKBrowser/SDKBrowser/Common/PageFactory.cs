using System;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Common
{
    public static class PageFactory
    {
        //Since this PageFactory relies on correct namespaces to create the actual example page out of a string
        //ANY NEW example should be created in a specific Namespace. It should be created in the SDKBrowser/Examples/{control name} folder
        private const string DEFAULT_EXAMPLES_NAMESPACE = "SDKBrowser.Examples.";

        public static ContentPage GetPage(string pageName, string pageTitle, bool isTestingMode = false)
        {
            var page = GetInstance(pageName) as ContentPage;
            page.Title = pageTitle;

            if (Device.OS == TargetPlatform.Android && pageName.Contains("Chart"))
            {
                page.BackgroundColor = Color.FromHex("E2E2E2");
            }

            if (isTestingMode && pageName.Contains("Calendar"))
            {
                (page.Content as RadCalendar).DisplayDate = new DateTime(1990, 1, 1);
            }

            return page;
        }

        private static object GetInstance(string controlAndClassName)
        {
            Type type = Type.GetType(DEFAULT_EXAMPLES_NAMESPACE + controlAndClassName);
            if (type != null)
            {
                return Activator.CreateInstance(type);
            }

            throw new ArgumentException(string.Format("Could not create actual page from the string: {0}! Check if the namespace of the example is correct.", DEFAULT_EXAMPLES_NAMESPACE + controlAndClassName));
        }
    }
}
