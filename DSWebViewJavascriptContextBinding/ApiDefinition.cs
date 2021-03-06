﻿using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.JavaScriptCore;

namespace DSWebViewJavascriptContextBinding
{
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

		[Export ("setBlockWith1Param:forKey:")]
		void SetBlock (Action<NSObject> block, string key);

		[Export ("setBlockWith2Param:forKey:")]
		void SetBlock (Action<NSObject,NSObject> block, string key);

		[Export ("setBlockWith3Param:forKey:")]
		void SetBlock (Action<NSObject,NSObject,NSObject> block, string key);

		[Export ("setBlockWith4Param:forKey:")]
		void SetBlock (Action<NSObject,NSObject,NSObject,NSObject> block, string key);

		[Export ("setBlockWith5Param:forKey:")]
		void SetBlock (Action<NSObject,NSObject,NSObject,NSObject,NSObject> block, string key);

		[Export ("setBlockWith6Param:forKey:")]
		void SetBlock (Action<NSObject,NSObject,NSObject,NSObject,NSObject,NSObject> block, string key);

		[Export ("setNumberBlock:forKey:")]
		void SetNumberBlock (Func<NSNumber> block, string key);

		[Export ("setNumberBlockWith1Param:forKey:")]
		void SetNumberBlock (Func<NSObject,NSNumber> block, string key);

		[Export ("setNumberBlockWith2Param:forKey:")]
		void SetNumberBlock (Action<NSObject,NSObject,NSNumber> block, string key);

		[Export ("setNumberBlockWith3Param:forKey:")]
		void SetNumberBlock (Action<NSObject,NSObject,NSObject,NSNumber> block, string key);

		[Export ("setNumberBlockWith4Param:forKey:")]
		void SetNumberBlock (Action<NSObject,NSObject,NSObject,NSObject,NSNumber> block, string key);

		[Export ("setNumberBlockWith5Param:forKey:")]
		void SetNumberBlock (Action<NSObject,NSObject,NSObject,NSObject,NSObject,NSNumber> block, string key);

		[Export ("setNumberBlockWith6Param:forKey:")]
		void SetNumberBlock (Action<NSObject,NSObject,NSObject,NSObject,NSObject,NSObject,NSNumber> block, string key);
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

		[Export ("setBlock:forKey:")]
		void SetBlock (Action block, string key);

		[Export ("setBlockWith1Param:forKey:")]
		void SetBlock (Action<NSObject> block, string key);

		[Export ("setBlockWith2Param:forKey:")]
		void SetBlock (Action<NSObject,NSObject> block, string key);

		[Export ("setBlockWith3Param:forKey:")]
		void SetBlock (Action<NSObject,NSObject,NSObject> block, string key);

		[Export ("setBlockWith4Param:forKey:")]
		void SetBlock (Action<NSObject,NSObject,NSObject,NSObject> block, string key);

		[Export ("setBlockWith5Param:forKey:")]
		void SetBlock (Action<NSObject,NSObject,NSObject,NSObject,NSObject> block, string key);

		[Export ("setBlockWith6Param:forKey:")]
		void SetBlock (Action<NSObject,NSObject,NSObject,NSObject,NSObject,NSObject> block, string key);

		[Export ("setNumberBlock:forKey:")]
		void SetNumberBlock (Func<NSNumber> block, string key);

		[Export ("setNumberBlockWith1Param:forKey:")]
		void SetNumberBlock (Func<NSObject,NSNumber> block, string key);

		[Export ("setNumberBlockWith2Param:forKey:")]
		void SetNumberBlock (Action<NSObject,NSObject,NSNumber> block, string key);

		[Export ("setNumberBlockWith3Param:forKey:")]
		void SetNumberBlock (Action<NSObject,NSObject,NSObject,NSNumber> block, string key);

		[Export ("setNumberBlockWith4Param:forKey:")]
		void SetNumberBlock (Action<NSObject,NSObject,NSObject,NSObject,NSNumber> block, string key);

		[Export ("setNumberBlockWith5Param:forKey:")]
		void SetNumberBlock (Action<NSObject,NSObject,NSObject,NSObject,NSObject,NSNumber> block, string key);

		[Export ("setNumberBlockWith6Param:forKey:")]
		void SetNumberBlock (Action<NSObject,NSObject,NSObject,NSObject,NSObject,NSObject,NSNumber> block, string key);
	}

	[BaseType (typeof(NSObject))]
	public partial interface DSHybridDelegate
	{
		[Export ("hybridApiUrl:")]
		void HandleCustomApiUrl (string customUrl);
	}
}

