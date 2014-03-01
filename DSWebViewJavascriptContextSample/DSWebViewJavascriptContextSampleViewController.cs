using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using DSWebViewJavascriptContextBinding;
using System.IO;

namespace DSWebViewJavascriptContextSample
{
	public partial class DSWebViewJavascriptContextSampleViewController : UIViewController
	{
		public DSWebViewJavascriptContextSampleViewController () : base ("DSWebViewJavascriptContextSampleViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();


			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			aWebView.Delegate = new DSWebDelegate ();

			string fileName = "Content/index.htm"; // remember case-sensitive
			string localHtmlUrl = Path.Combine (NSBundle.MainBundle.BundlePath, fileName);
			aWebView.LoadRequest (new NSUrlRequest (new NSUrl (localHtmlUrl, false)));
			aWebView.ScalesPageToFit = false;

		}
	}
}

