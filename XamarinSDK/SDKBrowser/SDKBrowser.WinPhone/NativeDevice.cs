using SDKBrowser.Common;
using SDKBrowser.WinPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(NativeDevice))]
namespace SDKBrowser.WinPhone
{
    public class NativeDevice : IDevice
    {
        public ExtendedDevice Device
        {
            get
            {
                return ExtendedDevice.WinPhone80;
            }
        }
    }
}
