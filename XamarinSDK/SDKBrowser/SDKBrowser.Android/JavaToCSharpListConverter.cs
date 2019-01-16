using System.Collections.Generic;
using Telerik.XamarinForms.Common.Android;

namespace SDKBrowser.Droid
{
    public class JavaToCSharpListConverter : ITypeConverter
    {
        public Java.Lang.Object Convert(object sourceObject)
        {
            Android.Runtime.JavaList items = null;
            List<string> cSharpList = sourceObject as List<string>;
            if (cSharpList != null)
            {
                items = new Android.Runtime.JavaList(cSharpList);
            }

            return items;
        }

        public object ConvertBack(Java.Lang.Object nativeObject)
        {
            List<string> items = null;
            var javaList = nativeObject as Android.Runtime.JavaList;
            if (javaList != null)
            {
                items = new List<string>();
                for (int i = 0; i < javaList.Size(); i++)
                {
                    items.Add(javaList[i].ToString());
                }
            }

            return items;
        }
    }
}