using System;
using DSWebViewJavascriptContextBinding;
using MonoTouch.UIKit;
using MonoTouch.JavaScriptCore;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace DSWebViewJavascriptContextSample
{
	public class DSWebDelegate : TSWebViewDelegate
	{
		public override void DidCreateJavaScriptContext (UIWebView webView, JSContext ctx)
		{
			if (ctx != null)
			{
				//set an NSObject value in to the context
				ctx.SetObject (webView, @"viewController");

				//Set an execution block in tothe context
				ctx.SetBlock (() => {

				}, @"doSomething");

				//ctx.GlobalObject.
				//ctx [new NSString (@"sayHello")] = webView;  
			}
		}
	}

	public interface someFunctions
	{
		void sayHello ();
	}
}

