using System;

using Xamarin.Forms;
using Telerik.XamarinForms.Input;
using SDKBrowser.Examples.DataForm.Source;

namespace SDKBrowser.Examples.DataForm
{
    public class DataFormSourceDataClass : ContentPage
    {
        public DataFormSourceDataClass()
        {
            // >> dataform-source-dataclass-dataform
            var dataForm = new RadDataForm
            {
                Source = new Customer()
            };
            // << dataform-source-dataclass-dataform

            Content = dataForm;
        }
    }
}

