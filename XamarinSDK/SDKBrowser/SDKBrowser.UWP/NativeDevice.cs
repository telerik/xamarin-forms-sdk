using SDKBrowser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKBrowser.UWP
{
    public class NativeDevice : IDevice
    {
        public ExtendedDevice Device
        {
            get
            {
                return ExtendedDevice.Windows10;
            }
        }
    }
}
