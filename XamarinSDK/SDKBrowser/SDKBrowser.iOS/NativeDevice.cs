using SDKBrowser.Common;
using SDKBrowser.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(NativeDevice))]
namespace SDKBrowser.iOS
{
    public class NativeDevice : IDevice
    {
        public ExtendedDevice Device
        {
            get
            {
                return ExtendedDevice.IOS;
            }
        }
    }
}