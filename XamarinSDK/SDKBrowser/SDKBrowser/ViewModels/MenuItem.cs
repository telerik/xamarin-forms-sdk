using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SDKBrowser
{
	public class MenuItem
	{
		public bool IsInfo { get; set; }
		public virtual string Title { get; set; }
		public virtual bool Selected { get; set; }

		public Func<Page> ExamplePage { get; set; }
	}

}
