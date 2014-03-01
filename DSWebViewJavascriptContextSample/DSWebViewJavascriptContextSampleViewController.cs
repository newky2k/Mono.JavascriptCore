using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using DSWebViewJavascriptContextBinding;

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

			aWebView.LoadRequest (new NSUrlRequest (new NSUrl ("http://www.google.com")));

			// Perform any additional setup after loading the view, typically from a nib.
			//var athing = new TS_JavaScriptContext_UIWebView ();

		}
	}
}

