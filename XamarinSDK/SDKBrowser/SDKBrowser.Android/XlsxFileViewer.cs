using System;
using System.IO;
using System.Threading.Tasks;
using Android.Content;
using Java.IO;
using SDKBrowser.Droid;
using SDKBrowser.Examples.SpreadStreamProcessing;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(XlsxFileViewer))]
namespace SDKBrowser.Droid
{
	public class XlsxFileViewer : IXlsxFileViewer
	{
		public Task View(Stream stream, string filename)
		{
			string root = null;

			if (Android.OS.Environment.IsExternalStorageEmulated)
			{
				root = Android.OS.Environment.ExternalStorageDirectory.ToString();
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
				Android.Net.Uri path = Android.Net.Uri.FromFile(file);

				string extension = Android.Webkit.MimeTypeMap.GetFileExtensionFromUrl(Android.Net.Uri.FromFile(file).ToString());
				string mimeType = Android.Webkit.MimeTypeMap.Singleton.GetMimeTypeFromExtension(extension);
				Intent intent = new Intent(Intent.ActionView);
				intent.SetDataAndType(path, mimeType);

				Forms.Context.StartActivity(Intent.CreateChooser(intent, "Choose App"));
			}

			return Task.CompletedTask;
		}
	}
}
