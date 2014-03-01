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

namespace MonoTouch.ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DJSObjectCallDelegate (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDJSObjectCallDelegate {
			static internal readonly DJSObjectCallDelegate Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DJSObjectCallDelegate))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::DSWebViewJavascriptContextBinding.JSObjectCallDelegate) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ();
			}
		} /* class SDJSObjectCallDelegate */
		
		internal class NIDJSObjectCallDelegate {
			IntPtr blockPtr;
			DJSObjectCallDelegate invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDJSObjectCallDelegate (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DJSObjectCallDelegate) Runtime.GetDelegateForBlock (block->invoke, typeof (DJSObjectCallDelegate));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::DSWebViewJavascriptContextBinding.JSObjectCallDelegate Create (IntPtr block)
			{
				return new NIDJSObjectCallDelegate ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDJSObjectCallDelegate */
	}
}