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


				///Attach a hybrid api handler
				DSHybridHandler.Attach (ctx);

				//load a property
				ctx.SetObject (ANumber, @"aNumber");

				//attach object to namespace
				ctx.SetObject ("webView", "aNumber", ANumber);

				//create an object that uses DSJavascriptObject as a base classes, which in turn exposes class members using JSExport
				//Note this can onl be done with the protocol in Obj-c not monotouch
				ctx.SetObject (new aClass (), @"aClass");

				//attach extra property to the aclass object
				ctx.SetObject ("aClass", "subNumber", ANumber);
			
				//set a execution block that can accept a number and return a number
				ctx.SetNumberBlock ((NSObject num) => {
					var toInt = num as NSNumber;

					var aInt = toInt.IntValue;

					return new NSNumber (aInt * 2);
				}, @"getInt");
					
				//Set an execution block in the context, 1 parameter no return type
				ctx.SetBlock ((obj) => {

					BeginInvokeOnMainThread (() => {
						//convert to string
						var name = obj.ToString ();

						//create message
						var message = String.Format ("Hello, {0}!", name);

						var aNewAler = new UIAlertView ("Welome", message, null, "OK", null);
						aNewAler.Show ();
					});


				}, @"sayHello");        


				///Multi-parameter void block
				ctx.SetBlock ((obj, obj2) => {
					BeginInvokeOnMainThread (() => {

						var firstName = obj.ToString ();
						var lastName = obj2.ToString ();

						var message = String.Format ("Hello, {0}{1}!", firstName, lastName);

						var aNewAler = new UIAlertView ("Welome", message, null, "OK", null);
						aNewAler.Show ();

					});

				}, @"sayFirstAndLastName");
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

	public class DSHybridHandler : DSHybridDelegate
	{
		/// <summary>
		/// Attach the specified context.
		/// </summary>
		/// <param name="ctx">Context.</param>
		public static void Attach (JSContext ctx)
		{
			//build an namespace structure for the class
			var aClass = ctx.GetOrCreate (@"DSoft");
			var aMobile = aClass.GetOrCreate (@"Online");
			aMobile.SetObject (new DSHybridHandler (), @"Native");
			aMobile.SetObject (new DSHybridHandler (), @"Cheese");
		}

		public override void HandleCustomApiUrl (string customUrl)
		{
			BeginInvokeOnMainThread (() => {
				var aNewAler = new UIAlertView ("Custom Url", customUrl, null, "OK", null);
				aNewAler.Show ();
			});

		}
	}
}