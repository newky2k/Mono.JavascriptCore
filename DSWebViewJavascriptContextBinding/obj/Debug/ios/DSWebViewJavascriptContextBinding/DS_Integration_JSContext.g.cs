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
	public unsafe static partial class DS_Integration_JSContext  {
		[CompilerGenerated]
		const string selSetObjectForKey_ = "setObject:forKey:";
		static readonly IntPtr selSetObjectForKey_Handle = Selector.GetHandle ("setObject:forKey:");
		[CompilerGenerated]
		const string selSetBlockForKey_ = "setBlock:forKey:";
		static readonly IntPtr selSetBlockForKey_Handle = Selector.GetHandle ("setBlock:forKey:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::MonoTouch.JavaScriptCore.JSContext");
		
		[Export ("setObject:forKey:")]
		[CompilerGenerated]
		public static void SetObject (this global::MonoTouch.JavaScriptCore.JSContext This, NSObject obj, string key)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, selSetObjectForKey_Handle, obj.Handle, nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("setBlock:forKey:")]
		[CompilerGenerated]
		public unsafe static void SetBlock (this global::MonoTouch.JavaScriptCore.JSContext This, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDJSObjectCallDelegate))]JSObjectCallDelegate block, string key)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			if (key == null)
				throw new ArgumentNullException ("key");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDJSObjectCallDelegate.Handler, block);
			var nskey = NSString.CreateNative (key);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, selSetBlockForKey_Handle, (IntPtr) block_ptr_block, nskey);
			block_ptr_block->CleanupBlock ();
			NSString.ReleaseNative (nskey);
			
		}
		
	} /* class DS_Integration_JSContext */
	public delegate void JSObjectCallDelegate ();
}
