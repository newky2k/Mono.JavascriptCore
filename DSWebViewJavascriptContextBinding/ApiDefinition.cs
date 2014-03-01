using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.JavaScriptCore;

namespace DSWebViewJavascriptContextBinding
{
	[Model]
	public interface JSExport
	{
	}

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
	#region Delegates
	public delegate void JSObjectCallDelegate ();
	public delegate void JSObjectCallDelegateParam1 (String param);
	#endregion
	[Category, BaseType (typeof(JSContext))]
	public partial interface DS_Integration_JSContext
	{
		[Export ("setObject:forKey:")]
		void SetObject (NSObject obj, string key);

		[Export ("setBlock:forKey:")]
		void SetBlock (JSObjectCallDelegate block, string key);

		[Export ("setBlockWithParam1:forKey:")]
		void SetBlock (JSObjectCallDelegateParam1 block, string key);
	}
}

