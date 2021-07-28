using System;
using System.IO;
using System.Threading.Tasks;
using Android.Content;
using Java.IO;
using SDKBrowser.Droid;
using SDKBrowser.Examples.SpreadStreamProcessingControl;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(XlsxFileViewer))]
namespace SDKBrowser.Droid
{
    public class XlsxFileViewer : IXlsxFileViewer
    {
        public async Task View(Stream stream, string filename)
        {
            if ((int)Android.OS.Build.VERSION.SdkInt >= 23)
            {
                bool result = await PermissionsHelper.RequestStorrageAccess();
                if (!result)
                {
                    return;
                }
            }

            string root = null;

            if (Android.OS.Environment.IsExternalStorageEmulated)
            {
                root = Android.App.Application.Context.GetExternalFilesDir(null).ToString();
            }
            else
            {
                root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            Java.IO.File myDir = new Java.IO.File(root + "/Telerik");
            myDir.Mkdir();
            Java.IO.File file = new Java.IO.File(myDir, filename);

            if (file.Exists())
            {
                file.Delete();
            }

            using (FileOutputStream outs = new FileOutputStream(file))
            {
                stream.Seek(0, SeekOrigin.Begin);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                outs.Write(buffer);
            }

            if (file.Exists())
            {
                var context = Android.App.Application.Context;
                Android.Net.Uri path = AndroidX.Core.Content.FileProvider.GetUriForFile(context, "SDKBrowser.Android.fileprovider", file);

                string extension = Android.Webkit.MimeTypeMap.GetFileExtensionFromUrl(Android.Net.Uri.FromFile(file).ToString());
                string mimeType = Android.Webkit.MimeTypeMap.Singleton.GetMimeTypeFromExtension(extension);
                Intent intent = new Intent(Intent.ActionView);
                intent.SetDataAndType(path, mimeType);
                intent.AddFlags(ActivityFlags.GrantReadUriPermission);

                var chooser = Intent.CreateChooser(intent, "Choose App");
                chooser.SetFlags(ActivityFlags.NewTask);
                chooser.AddFlags(ActivityFlags.GrantReadUriPermission);
                context.StartActivity(chooser);
            }

            return;
        }
    }
}
