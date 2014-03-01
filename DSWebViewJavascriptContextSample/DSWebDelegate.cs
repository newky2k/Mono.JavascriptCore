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

				//Set an execution block in the context
				ctx.SetBlock ((obj) => {
					var obj2 = obj;

					var aNewAler = new UIAlertView ("Hello", "", null, "OK", null);
					aNewAler.Show ();

				}, @"doSomething");        

				//ctx.GlobalObject.
				//ctx [new NSString (@"sayHello")] = webView;  
			}
		}
	}
}

