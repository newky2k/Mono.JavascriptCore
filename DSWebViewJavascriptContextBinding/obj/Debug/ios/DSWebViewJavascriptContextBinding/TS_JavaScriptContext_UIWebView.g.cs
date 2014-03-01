//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace DSWebViewJavascriptContextBinding {
	public unsafe static partial class TS_JavaScriptContext_UIWebView  {
		[CompilerGenerated]
		const string selRetriveJSContext_ = "retriveJSContext:";
		static readonly IntPtr selRetriveJSContext_Handle = Selector.GetHandle ("retriveJSContext:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::MonoTouch.UIKit.UIWebView");
		
		[Export ("retriveJSContext:")]
		[CompilerGenerated]
		public static global::MonoTouch.JavaScriptCore.JSContext RetriveJSContext (this global::MonoTouch.UIKit.UIWebView This, NSObject notused)
		{
			if (notused == null)
				throw new ArgumentNullException ("notused");
			return  Runtime.GetNSObject<global::MonoTouch.JavaScriptCore.JSContext> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, selRetriveJSContext_Handle, notused.Handle));
		}
		
	} /* class TS_JavaScriptContext_UIWebView */
}
