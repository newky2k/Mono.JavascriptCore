using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libDSWebViewJavascriptContextSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, ForceLoad = true, Frameworks = "Foundation UIKit JavaScriptCore")]
