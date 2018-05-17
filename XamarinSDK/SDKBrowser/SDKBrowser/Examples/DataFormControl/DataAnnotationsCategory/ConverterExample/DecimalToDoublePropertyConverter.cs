using Telerik.XamarinForms.Common.DataAnnotations;

namespace SDKBrowser.Examples.DataFormControl.DataAnnotationsCategory.ConverterExample
{
    // >> dataform-dataannotations-converter-decimaltodoublepropertyconverter
    class DecimalToDoublePropertyConverter : IPropertyConverter
    {
        public object Convert(object value)
        {
            return System.Convert.ToDouble((decimal)value);
        }

        public object ConvertBack(object value)
        {
            return System.Convert.ToDecimal((double)value);
        }
    }
    // << dataform-dataannotations-converter-decimaltodoublepropertyconverter
}