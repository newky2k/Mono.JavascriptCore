using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.JavaScriptCore;

namespace DSWebViewJavascriptContextBinding
{
	[BaseType (typeof(NSObject))]
	[Model][Protocol]
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
	}

	[Category, BaseType (typeof(UIWebView))]
	public partial interface DSIntegration_UIWebView
	{
		[Export ("retriveJSContext:")]
		JSContext RetriveJSContext (NSObject notused);
	}

	[Category, BaseType (typeof(JSContext))]
	public partial interface DSIntegration_JSContext
	{
		[Export ("setObject:forKey:")]
		void SetObject (NSObject obj, string key);

		[Export ("setBlock:forKey:")]
		void SetBlock (Action block, string key);

		[Export ("setBlockWithParam1:forKey:")]
		void SetBlock (Action<String> block, string key);

		[Export ("setNumberBlock:forKey:")]
		void SetNumberBlock (Func<NSNumber,NSNumber> block, string key);
	}

	[BaseType (typeof(NSObject))]
	public partial interface DSJavascriptObject
	{
		[Export ("getProperty:")]
		NSObject GetProperty (string name);

		[Export ("setNumberPropertyWithName:number:")]
		void SetProperty (string name, NSNumber value);
	}

	[Category, BaseType (typeof(JSValue))]
	public partial interface DSIntegration_JSValue
	{
		[Export ("setObject:forKey:")]
		void SetObject (NSObject obj, string key);
	}

	[BaseType (typeof(NSObject))]
	public partial interface DSHybridDelegate
	{
		[Export ("hybridApiUrl:")]
		void HandleCustomApiUrl (string customUrl);
	}
}

