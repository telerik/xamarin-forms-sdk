using SDKBrowser.Common;
using SDKBrowser.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(NativeDevice))]
namespace SDKBrowser.Droid
{
    public class NativeDevice : IDevice
    {
        public ExtendedDevice Device
        {
            get
            {
                return ExtendedDevice.Android;
            }
        }
    }
}