// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace DSWebViewJavascriptContextSample
{
	[Register ("DSWebViewJavascriptContextSampleViewController")]
	partial class DSWebViewJavascriptContextSampleViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIWebView aWebView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (aWebView != null) {
				aWebView.Dispose ();
				aWebView = null;
			}
		}
	}
}
