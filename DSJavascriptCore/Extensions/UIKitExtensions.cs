using System;
using MonoTouch.UIKit;
using DSWebViewJavascriptContextBinding;
using MonoTouch.JavaScriptCore;

namespace MonoTouch.UIKit
{
	public static class UIKitExtensions
	{
		/// <summary>
		/// Gets the Javascript context for the web view
		/// </summary>
		/// <returns>The JS context.</returns>
		/// <param name="wv">Wv.</param>
		public static JSContext GetJSContext (this UIWebView wv)
		{
			return wv.RetriveJSContext (wv);
		}
	}
}

