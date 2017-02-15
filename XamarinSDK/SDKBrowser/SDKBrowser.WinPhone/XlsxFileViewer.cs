using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDKBrowser.Examples.SpreadStreamProcessing;
using SDKBrowser.WinPhone;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency(typeof(XlsxFileViewer))]
namespace SDKBrowser.WinPhone
{
    public class XlsxFileViewer : IXlsxFileViewer
    {
        public async Task View(Stream stream, string filename)
        {
            var temporatyFolder = ApplicationData.Current.LocalFolder;

            var file = await temporatyFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
            stream.Seek(0, SeekOrigin.Begin);

            using (var fileStream = await file.OpenAsync(FileAccessMode.ReadWrite))
            {
                using (var managedFileStream = fileStream.AsStreamForWrite())
                {
                    stream.CopyTo(managedFileStream);
                }
            }

            await Windows.System.Launcher.LaunchFileAsync(file);
        }
    }
}
