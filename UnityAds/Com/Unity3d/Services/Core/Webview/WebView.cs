using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Webkit;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview
{
	// Token: 0x0200006D RID: 109
	[Register("com/unity3d/services/core/webview/WebView", DoNotGenerateAcw = true)]
	public class WebView : WebView
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00009D24 File Offset: 0x00007F24
		internal static IntPtr class_ref
		{
			get
			{
				return WebView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00009D48 File Offset: 0x00007F48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebView._members;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00009D50 File Offset: 0x00007F50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00009D74 File Offset: 0x00007F74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebView._members.ManagedPeerType;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00009D80 File Offset: 0x00007F80
		protected WebView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00009D8C File Offset: 0x00007F8C
		[Register(".ctor", "(Landroid/content/Context;Z)V", "")]
		public unsafe WebView(Context context, bool shouldNotRequireGesturePlayback) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(WebView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00009E4C File Offset: 0x0000804C
		private static Delegate GetInvokeJavascript_Ljava_lang_String_Handler()
		{
			if (WebView.cb_invokeJavascript_Ljava_lang_String_ == null)
			{
				WebView.cb_invokeJavascript_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebView.n_InvokeJavascript_Ljava_lang_String_));
			}
			return WebView.cb_invokeJavascript_Ljava_lang_String_;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00009E70 File Offset: 0x00008070
		private static void n_InvokeJavascript_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			WebView @object = Java.Lang.Object.GetObject<WebView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_data, JniHandleOwnership.DoNotTransfer);
			@object.InvokeJavascript(@string);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00009E94 File Offset: 0x00008094
		[Register("invokeJavascript", "(Ljava/lang/String;)V", "GetInvokeJavascript_Ljava_lang_String_Handler")]
		public unsafe virtual void InvokeJavascript(string data)
		{
			IntPtr intPtr = JNIEnv.NewString(data);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebView._members.InstanceMethods.InvokeVirtualVoidMethod("invokeJavascript.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040000AC RID: 172
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/WebView", typeof(WebView));

		// Token: 0x040000AD RID: 173
		private static Delegate cb_invokeJavascript_Ljava_lang_String_;
	}
}
