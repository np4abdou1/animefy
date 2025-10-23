using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Webview
{
	// Token: 0x02000071 RID: 113
	[Register("com/unity3d/services/core/webview/WebViewWithCache", DoNotGenerateAcw = true)]
	public class WebViewWithCache : WebView
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000B3A0 File Offset: 0x000095A0
		internal new static IntPtr class_ref
		{
			get
			{
				return WebViewWithCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000B3C4 File Offset: 0x000095C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewWithCache._members;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000B3CC File Offset: 0x000095CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewWithCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0000B3F0 File Offset: 0x000095F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewWithCache._members.ManagedPeerType;
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000B3FC File Offset: 0x000095FC
		protected WebViewWithCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000B408 File Offset: 0x00009608
		[Register(".ctor", "(Landroid/content/Context;Z)V", "")]
		public unsafe WebViewWithCache(Context context, bool shouldNotRequireGesturePlayback) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(shouldNotRequireGesturePlayback);
				base.SetHandle(WebViewWithCache._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebViewWithCache._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x040000C6 RID: 198
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/WebViewWithCache", typeof(WebViewWithCache));
	}
}
