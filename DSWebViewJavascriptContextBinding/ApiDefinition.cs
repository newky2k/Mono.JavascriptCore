using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.JavaScriptCore;

namespace DSWebViewJavascriptContextBinding
{
	public delegate void JSObjectCallDelegate ();
	[Model, BaseType (typeof(UIWebViewDelegate))]
	public partial interface TSWebViewDelegate
	{
		[Export ("webView:didCreateJavaScriptContext:")]
		void DidCreateJavaScriptContext (UIWebView webView, JSContext ctx);
	}

	[Category, BaseType (typeof(UIWebView))]
	public partial interface TS_JavaScriptContext_UIWebView
	{
		[Export ("retriveJSContext:")]
		JSContext RetriveJSContext (NSObject notused);
	}

	[Category, BaseType (typeof(JSContext))]
	public partial interface DS_Integration_JSContext
	{
		[Export ("setObject:forKey:")]
		void SetObject (NSObject obj, string key);

		[Export ("setBlock:forKey:")]
		void SetBlock (JSObjectCallDelegate block, string key);
	}
}

