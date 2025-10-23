using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200003E RID: 62
	[Register("com/adcolony/sdk/AdColonyAdView", DoNotGenerateAcw = true)]
	public class AdColonyAdView : FrameLayout
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00007B78 File Offset: 0x00005D78
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyAdView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00007B9C File Offset: 0x00005D9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyAdView._members;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00007BA4 File Offset: 0x00005DA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyAdView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00007BC8 File Offset: 0x00005DC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyAdView._members.ManagedPeerType;
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00007BD4 File Offset: 0x00005DD4
		protected AdColonyAdView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00007BDE File Offset: 0x00005DDE
		private static Delegate GetGetAdSizeHandler()
		{
			if (AdColonyAdView.cb_getAdSize == null)
			{
				AdColonyAdView.cb_getAdSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAdView.n_GetAdSize));
			}
			return AdColonyAdView.cb_getAdSize;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00007C02 File Offset: 0x00005E02
		private static IntPtr n_GetAdSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdSize);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00007C18 File Offset: 0x00005E18
		public virtual AdColonyAdSize AdSize
		{
			[Register("getAdSize", "()Lcom/adcolony/sdk/AdColonyAdSize;", "GetGetAdSizeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AdColonyAdSize>(AdColonyAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getAdSize.()Lcom/adcolony/sdk/AdColonyAdSize;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00007C4A File Offset: 0x00005E4A
		private static Delegate GetGetListenerHandler()
		{
			if (AdColonyAdView.cb_getListener == null)
			{
				AdColonyAdView.cb_getListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAdView.n_GetListener));
			}
			return AdColonyAdView.cb_getListener;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00007C6E File Offset: 0x00005E6E
		private static IntPtr n_GetListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Listener);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00007C82 File Offset: 0x00005E82
		private static Delegate GetSetListener_Lcom_adcolony_sdk_AdColonyAdViewListener_Handler()
		{
			if (AdColonyAdView.cb_setListener_Lcom_adcolony_sdk_AdColonyAdViewListener_ == null)
			{
				AdColonyAdView.cb_setListener_Lcom_adcolony_sdk_AdColonyAdViewListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyAdView.n_SetListener_Lcom_adcolony_sdk_AdColonyAdViewListener_));
			}
			return AdColonyAdView.cb_setListener_Lcom_adcolony_sdk_AdColonyAdViewListener_;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00007CA8 File Offset: 0x00005EA8
		private static void n_SetListener_Lcom_adcolony_sdk_AdColonyAdViewListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			AdColonyAdView @object = Java.Lang.Object.GetObject<AdColonyAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyAdViewListener object2 = Java.Lang.Object.GetObject<AdColonyAdViewListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.Listener = object2;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00007CCC File Offset: 0x00005ECC
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00007D00 File Offset: 0x00005F00
		public unsafe virtual AdColonyAdViewListener Listener
		{
			[Register("getListener", "()Lcom/adcolony/sdk/AdColonyAdViewListener;", "GetGetListenerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AdColonyAdViewListener>(AdColonyAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getListener.()Lcom/adcolony/sdk/AdColonyAdViewListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setListener", "(Lcom/adcolony/sdk/AdColonyAdViewListener;)V", "GetSetListener_Lcom_adcolony_sdk_AdColonyAdViewListener_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AdColonyAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setListener.(Lcom/adcolony/sdk/AdColonyAdViewListener;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00007D64 File Offset: 0x00005F64
		private static Delegate GetGetZoneIdHandler()
		{
			if (AdColonyAdView.cb_getZoneId == null)
			{
				AdColonyAdView.cb_getZoneId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAdView.n_GetZoneId));
			}
			return AdColonyAdView.cb_getZoneId;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00007D88 File Offset: 0x00005F88
		private static IntPtr n_GetZoneId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ZoneId);
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00007D9C File Offset: 0x00005F9C
		public virtual string ZoneId
		{
			[Register("getZoneId", "()Ljava/lang/String;", "GetGetZoneIdHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getZoneId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00007DCE File Offset: 0x00005FCE
		private static Delegate GetDestroyHandler()
		{
			if (AdColonyAdView.cb_destroy == null)
			{
				AdColonyAdView.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyAdView.n_Destroy));
			}
			return AdColonyAdView.cb_destroy;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00007DF2 File Offset: 0x00005FF2
		private static bool n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00007E01 File Offset: 0x00006001
		[Register("destroy", "()Z", "GetDestroyHandler")]
		public virtual bool Destroy()
		{
			return AdColonyAdView._members.InstanceMethods.InvokeVirtualBooleanMethod("destroy.()Z", this, null);
		}

		// Token: 0x04000066 RID: 102
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyAdView", typeof(AdColonyAdView));

		// Token: 0x04000067 RID: 103
		private static Delegate cb_getAdSize;

		// Token: 0x04000068 RID: 104
		private static Delegate cb_getListener;

		// Token: 0x04000069 RID: 105
		private static Delegate cb_setListener_Lcom_adcolony_sdk_AdColonyAdViewListener_;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_getZoneId;

		// Token: 0x0400006B RID: 107
		private static Delegate cb_destroy;
	}
}
