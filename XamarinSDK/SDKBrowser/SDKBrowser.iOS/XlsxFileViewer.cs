using System;
using System.IO;
using System.Threading.Tasks;
using Foundation;
using QuickLook;
using SDKBrowser.Examples.SpreadStreamProcessingControl;
using SDKBrowser.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(XlsxFileViewer))]
namespace SDKBrowser.iOS
{
    public class XlsxFileViewer : IXlsxFileViewer
	{
		public Task View(Stream stream, string filename)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

			string filePath = Path.Combine(path, filename);

			using (FileStream fileStream = File.Open(filePath, FileMode.Create))
			{
				stream.Seek(0, SeekOrigin.Begin);
				stream.CopyTo(fileStream);
			}

			UIViewController currentController = UIApplication.SharedApplication.KeyWindow.RootViewController;

			while (currentController.PresentedViewController != null)
			{
				currentController = currentController.PresentedViewController;
			}

			UIView currentView = currentController.View;

			QLPreviewController qlPreview = new QLPreviewController();

			QLPreviewItem item = new QLPreviewItemBundle(filename, filePath);

			qlPreview.DataSource = new PreviewControllerDS(item);

			currentController.PresentViewController(qlPreview, true, null);

			return Task.CompletedTask;
		}
	}

	public class QLPreviewItemBundle : QLPreviewItem
	{
		string _fileName, _filePath;
		public QLPreviewItemBundle(string fileName, string filePath)
		{
			_fileName = fileName;
			_filePath = filePath;
		}

		public override string ItemTitle
		{
			get
			{
				return _fileName;
			}
		}

		public override NSUrl ItemUrl
		{
			get
			{
				var documents = NSBundle.MainBundle.BundlePath;
				var lib = Path.Combine(documents, _filePath);
				var url = NSUrl.FromFilename(lib);
				return url;
			}
		}
	}

	public class PreviewControllerDS : QLPreviewControllerDataSource
	{
		private QLPreviewItem _item;

		public PreviewControllerDS(QLPreviewItem item)
		{
			_item = item;
		}

		public override IQLPreviewItem GetPreviewItem(QLPreviewController controller, nint index)
		{
			return _item;
		}

		public override nint PreviewItemCount(QLPreviewController controller)
		{
			return 1;
		}
	}
}
