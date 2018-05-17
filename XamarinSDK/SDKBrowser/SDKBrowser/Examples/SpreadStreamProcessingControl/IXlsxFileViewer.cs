using System.IO;
using System.Threading.Tasks;

namespace SDKBrowser.Examples.SpreadStreamProcessingControl
{
	public interface IXlsxFileViewer
	{
		Task View(Stream stream, string filename);
	}
}
