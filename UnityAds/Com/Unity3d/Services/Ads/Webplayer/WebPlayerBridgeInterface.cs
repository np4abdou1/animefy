using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Webplayer
{
	// Token: 0x020001CE RID: 462
	[Register("com/unity3d/services/ads/webplayer/WebPlayerBridgeInterface", DoNotGenerateAcw = true)]
	public class WebPlayerBridgeInterface : Java.Lang.Object
	{
		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0003B860 File Offset: 0x00039A60
		internal static IntPtr class_ref
		{
			get
			{
				return WebPlayerBridgeInterface._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x0003B884 File Offset: 0x00039A84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebPlayerBridgeInterface._members;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x0003B88C File Offset: 0x00039A8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebPlayerBridgeInterface._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x0003B8B0 File Offset: 0x00039AB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebPlayerBridgeInterface._members.ManagedPeerType;
			}
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebPlayerBridgeInterface(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0003B8BC File Offset: 0x00039ABC
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe WebPlayerBridgeInterface(string viewId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(WebPlayerBridgeInterface._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebPlayerBridgeInterface._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0003B960 File Offset: 0x00039B60
		private static Delegate GetHandleEvent_Ljava_lang_String_Handler()
		{
			if (WebPlayerBridgeInterface.cb_handleEvent_Ljava_lang_String_ == null)
			{
				WebPlayerBridgeInterface.cb_handleEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerBridgeInterface.n_HandleEvent_Ljava_lang_String_));
			}
			return WebPlayerBridgeInterface.cb_handleEvent_Ljava_lang_String_;
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0003B984 File Offset: 0x00039B84
		private static void n_HandleEvent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			WebPlayerBridgeInterface @object = Java.Lang.Object.GetObject<WebPlayerBridgeInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_data, JniHandleOwnership.DoNotTransfer);
			@object.HandleEvent(@string);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0003B9A8 File Offset: 0x00039BA8
		[Register("handleEvent", "(Ljava/lang/String;)V", "GetHandleEvent_Ljava_lang_String_Handler")]
		public unsafe virtual void HandleEvent(string data)
		{
			IntPtr intPtr = JNIEnv.NewString(data);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebPlayerBridgeInterface._members.InstanceMethods.InvokeVirtualVoidMethod("handleEvent.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040004F9 RID: 1273
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/webplayer/WebPlayerBridgeInterface", typeof(WebPlayerBridgeInterface));

		// Token: 0x040004FA RID: 1274
		private static Delegate cb_handleEvent_Ljava_lang_String_;
	}
}
