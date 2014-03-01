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
				//set a value
				this.ANumber = 20;

				//set an NSObject value in to the context
				ctx.SetObject (webView, @"webView");
				ctx.SetObject (this, @"webDelegate");

				//load a property
				ctx.SetObject (ANumber, @"aNumber");

				//create an object that uses DSJavascriptObject as a base classes, which in turn exposes class member using JSExport
				ctx.SetObject (new aClass (), @"aClass");

				//set a execution block that can accept a number and return a number
				ctx.SetNumberBlock ((NSNumber num) => {
					var toInt = num.IntValue;

					return new NSNumber (toInt * 2);
				}, @"getInt");
					
				//the same as above but a method with the class
				ctx.SetNumberBlock (GetInt2, @"getInt2");

				//Set an execution block in the context, 1 parameter no return type
				ctx.SetBlock ((obj) => {

					var anObject = ctx [new NSString (@"aNumber")];
					//convert to string
					var name = obj.ToString ();

					//create message
					var message = String.Format ("Hello, {0}!", name);

					var aNewAler = new UIAlertView ("Welome", message, null, "OK", null);
					aNewAler.Show ();

				}, @"sayHello");        

			}
		}

		[Export ("getInt2")]
		public NSNumber GetInt2 (NSNumber num)
		{
			return num;
		}

		public override bool ShouldStartLoad (UIWebView webView, NSUrlRequest request, UIWebViewNavigationType navigationType)
		{
			//notice this is only called when the page is first loaded not when the 
			return true;
		}

		public NSNumber ANumber {
			get;
			set;
		}
	}

	/// <summary>
	/// A sub class of DSJavascript object which has some functionality exposed directly to JSContext
	/// </summary>
	public class aClass : DSJavascriptObject
	{
		/// <summary>
		/// Gets the property.
		/// </summary>
		/// <returns>The property.</returns>
		/// <param name="name">Name.</param>
		public override NSObject GetProperty (string name)
		{
			return new NSNumber (1000);
		}

		/// <summary>
		/// Sets the property.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="value">Value.</param>
		public override void SetProperty (string name, NSNumber value)
		{
			base.SetProperty (name, value);
		}
	}
}