using System;
using System.IO;
using System.Threading.Tasks;
using SDKBrowser.Examples.SpreadStreamProcessing;
using SDKBrowser.UWP;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency(typeof(XlsxFileViewer))]
namespace SDKBrowser.UWP
{
    public class XlsxFileViewer : IXlsxFileViewer
    {
        public async Task View(Stream stream, string filename)
        {
            var temporatyFolder = ApplicationData.Current.TemporaryFolder;

            var file = await temporatyFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
            stream.Seek(0, SeekOrigin.Begin);

            using (var fileStream = await file.OpenAsync(FileAccessMode.ReadWrite))
            {
                using (var managedFileStream = fileStream.AsStreamForWrite())
                {
                    stream.CopyTo(managedFileStream);
                }
            }

            // Set the option to show the picker
            var options = new Windows.System.LauncherOptions();
            options.DisplayApplicationPicker = true;

            // Launch the retrieved file
            await Windows.System.Launcher.LaunchFileAsync(file, options);
        }
    }
}
