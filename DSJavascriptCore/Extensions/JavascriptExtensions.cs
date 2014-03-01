using System;
using DSWebViewJavascriptContextBinding;
using MonoTouch.Foundation;

namespace MonoTouch.JavaScriptCore
{
	public static class JavascriptExtensions
	{
		/// <summary>
		/// Gets the JSValue or creates it if not found
		/// </summary>
		/// <returns>The or create.</returns>
		/// <param name="ctx">Context.</param>
		/// <param name="Name">Name.</param>
		public static JSValue GetOrCreate (this JSContext ctx, string Name)
		{
			var aClass = ctx [new NSString (Name)];

			if (aClass == null || aClass.IsUndefined)
			{
				ctx.SetObject (new NSObject (), Name);
				aClass = ctx [new NSString (Name)];
			}

			return aClass;
		}

		/// <summary>
		/// Gets the JSValue or creates it if not found
		/// </summary>
		/// <returns>The or create.</returns>
		/// <param name="ctx">Context.</param>
		/// <param name="Name">Name.</param>
		public static JSValue GetOrCreate (this JSValue ctx, string Name)
		{
			var aClass = ctx [new NSString (Name)];

			if (aClass == null || aClass.IsUndefined)
			{
				ctx.SetObject (new NSObject (), Name);
				aClass = ctx [new NSString (Name)];
			}

			return aClass;
		}

		public static void UpdateObject (this JSContext ctx, string Name, JSValue Data)
		{
			ctx [new NSString (Name)] = Data;
		}

		public static void UpdateObject (this JSValue ctx, string Name, JSValue Data)
		{
			ctx [new NSString (Name)] = Data;
		}

		public static JSValue BuildNamespace (this JSContext ctx, String Namespace)
		{
			//split the namespace into sections
			var names = Namespace.Split ('.');

			JSValue jsObject = null;

			foreach (var aName in names)
			{
				if (jsObject == null)
				{
					var anObject = ctx [new NSString (aName)];

					if (anObject != null)
					{
						jsObject = anObject;
					}
					else
					{
						//creat an object and load it back
						ctx.SetObject (new NSObject (), aName);
						jsObject = ctx [new NSString (aName)];

					}
				}
				else
				{
					var anObject = jsObject [new NSString (aName)];

					if (anObject != null)
					{
						jsObject = anObject;
					}
					else
					{
						//creat an object and load it back
						jsObject.SetObject (new NSObject (), aName);
						jsObject = jsObject [new NSString (aName)];

					}
				}
			}

			return jsObject;

		}
	}
}

