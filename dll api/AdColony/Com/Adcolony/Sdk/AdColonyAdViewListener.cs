using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200003F RID: 63
	[Register("com/adcolony/sdk/AdColonyAdViewListener", DoNotGenerateAcw = true)]
	public abstract class AdColonyAdViewListener : Java.Lang.Object
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00007E38 File Offset: 0x00006038
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyAdViewListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00007E5C File Offset: 0x0000605C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyAdViewListener._members;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00007E64 File Offset: 0x00006064
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyAdViewListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00007E88 File Offset: 0x00006088
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyAdViewListener._members.ManagedPeerType;
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyAdViewListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00007E94 File Offset: 0x00006094
		[Register(".ctor", "()V", "")]
		public AdColonyAdViewListener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdColonyAdViewListener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdColonyAdViewListener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00007F02 File Offset: 0x00006102
		private static Delegate GetOnClicked_Lcom_adcolony_sdk_AdColonyAdView_Handler()
		{
			if (AdColonyAdViewListener.cb_onClicked_Lcom_adcolony_sdk_AdColonyAdView_ == null)
			{
				AdColonyAdViewListener.cb_onClicked_Lcom_adcolony_sdk_AdColonyAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyAdViewListener.n_OnClicked_Lcom_adcolony_sdk_AdColonyAdView_));
			}
			return AdColonyAdViewListener.cb_onClicked_Lcom_adcolony_sdk_AdColonyAdView_;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00007F28 File Offset: 0x00006128
		private static void n_OnClicked_Lcom_adcolony_sdk_AdColonyAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyAdViewListener @object = Java.Lang.Object.GetObject<AdColonyAdViewListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyAdView object2 = Java.Lang.Object.GetObject<AdColonyAdView>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnClicked(object2);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00007F4C File Offset: 0x0000614C
		[Register("onClicked", "(Lcom/adcolony/sdk/AdColonyAdView;)V", "GetOnClicked_Lcom_adcolony_sdk_AdColonyAdView_Handler")]
		public unsafe virtual void OnClicked(AdColonyAdView ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyAdViewListener._members.InstanceMethods.InvokeVirtualVoidMethod("onClicked.(Lcom/adcolony/sdk/AdColonyAdView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00007FB0 File Offset: 0x000061B0
		private static Delegate GetOnClosed_Lcom_adcolony_sdk_AdColonyAdView_Handler()
		{
			if (AdColonyAdViewListener.cb_onClosed_Lcom_adcolony_sdk_AdColonyAdView_ == null)
			{
				AdColonyAdViewListener.cb_onClosed_Lcom_adcolony_sdk_AdColonyAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyAdViewListener.n_OnClosed_Lcom_adcolony_sdk_AdColonyAdView_));
			}
			return AdColonyAdViewListener.cb_onClosed_Lcom_adcolony_sdk_AdColonyAdView_;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00007FD4 File Offset: 0x000061D4
		private static void n_OnClosed_Lcom_adcolony_sdk_AdColonyAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyAdViewListener @object = Java.Lang.Object.GetObject<AdColonyAdViewListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyAdView object2 = Java.Lang.Object.GetObject<AdColonyAdView>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnClosed(object2);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Register("onClosed", "(Lcom/adcolony/sdk/AdColonyAdView;)V", "GetOnClosed_Lcom_adcolony_sdk_AdColonyAdView_Handler")]
		public unsafe virtual void OnClosed(AdColonyAdView ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyAdViewListener._members.InstanceMethods.InvokeVirtualVoidMethod("onClosed.(Lcom/adcolony/sdk/AdColonyAdView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000805C File Offset: 0x0000625C
		private static Delegate GetOnLeftApplication_Lcom_adcolony_sdk_AdColonyAdView_Handler()
		{
			if (AdColonyAdViewListener.cb_onLeftApplication_Lcom_adcolony_sdk_AdColonyAdView_ == null)
			{
				AdColonyAdViewListener.cb_onLeftApplication_Lcom_adcolony_sdk_AdColonyAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyAdViewListener.n_OnLeftApplication_Lcom_adcolony_sdk_AdColonyAdView_));
			}
			return AdColonyAdViewListener.cb_onLeftApplication_Lcom_adcolony_sdk_AdColonyAdView_;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00008080 File Offset: 0x00006280
		private static void n_OnLeftApplication_Lcom_adcolony_sdk_AdColonyAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyAdViewListener @object = Java.Lang.Object.GetObject<AdColonyAdViewListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyAdView object2 = Java.Lang.Object.GetObject<AdColonyAdView>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnLeftApplication(object2);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000080A4 File Offset: 0x000062A4
		[Register("onLeftApplication", "(Lcom/adcolony/sdk/AdColonyAdView;)V", "GetOnLeftApplication_Lcom_adcolony_sdk_AdColonyAdView_Handler")]
		public unsafe virtual void OnLeftApplication(AdColonyAdView ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyAdViewListener._members.InstanceMethods.InvokeVirtualVoidMethod("onLeftApplication.(Lcom/adcolony/sdk/AdColonyAdView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00008108 File Offset: 0x00006308
		private static Delegate GetOnOpened_Lcom_adcolony_sdk_AdColonyAdView_Handler()
		{
			if (AdColonyAdViewListener.cb_onOpened_Lcom_adcolony_sdk_AdColonyAdView_ == null)
			{
				AdColonyAdViewListener.cb_onOpened_Lcom_adcolony_sdk_AdColonyAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyAdViewListener.n_OnOpened_Lcom_adcolony_sdk_AdColonyAdView_));
			}
			return AdColonyAdViewListener.cb_onOpened_Lcom_adcolony_sdk_AdColonyAdView_;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000812C File Offset: 0x0000632C
		private static void n_OnOpened_Lcom_adcolony_sdk_AdColonyAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyAdViewListener @object = Java.Lang.Object.GetObject<AdColonyAdViewListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyAdView object2 = Java.Lang.Object.GetObject<AdColonyAdView>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnOpened(object2);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00008150 File Offset: 0x00006350
		[Register("onOpened", "(Lcom/adcolony/sdk/AdColonyAdView;)V", "GetOnOpened_Lcom_adcolony_sdk_AdColonyAdView_Handler")]
		public unsafe virtual void OnOpened(AdColonyAdView ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyAdViewListener._members.InstanceMethods.InvokeVirtualVoidMethod("onOpened.(Lcom/adcolony/sdk/AdColonyAdView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000081B4 File Offset: 0x000063B4
		private static Delegate GetOnRequestFilled_Lcom_adcolony_sdk_AdColonyAdView_Handler()
		{
			if (AdColonyAdViewListener.cb_onRequestFilled_Lcom_adcolony_sdk_AdColonyAdView_ == null)
			{
				AdColonyAdViewListener.cb_onRequestFilled_Lcom_adcolony_sdk_AdColonyAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyAdViewListener.n_OnRequestFilled_Lcom_adcolony_sdk_AdColonyAdView_));
			}
			return AdColonyAdViewListener.cb_onRequestFilled_Lcom_adcolony_sdk_AdColonyAdView_;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000081D8 File Offset: 0x000063D8
		private static void n_OnRequestFilled_Lcom_adcolony_sdk_AdColonyAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdColonyAdViewListener @object = Java.Lang.Object.GetObject<AdColonyAdViewListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyAdView object2 = Java.Lang.Object.GetObject<AdColonyAdView>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRequestFilled(object2);
		}

		// Token: 0x0600027D RID: 637
		[Register("onRequestFilled", "(Lcom/adcolony/sdk/AdColonyAdView;)V", "GetOnRequestFilled_Lcom_adcolony_sdk_AdColonyAdView_Handler")]
		public abstract void OnRequestFilled(AdColonyAdView p0);

		// Token: 0x0600027E RID: 638 RVA: 0x000081FB File Offset: 0x000063FB
		private static Delegate GetOnRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_Handler()
		{
			if (AdColonyAdViewListener.cb_onRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_ == null)
			{
				AdColonyAdViewListener.cb_onRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyAdViewListener.n_OnRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_));
			}
			return AdColonyAdViewListener.cb_onRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00008220 File Offset: 0x00006420
		private static void n_OnRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_(IntPtr jnienv, IntPtr native__this, IntPtr native_zone)
		{
			AdColonyAdViewListener @object = Java.Lang.Object.GetObject<AdColonyAdViewListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyZone object2 = Java.Lang.Object.GetObject<AdColonyZone>(native_zone, JniHandleOwnership.DoNotTransfer);
			@object.OnRequestNotFilled(object2);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00008244 File Offset: 0x00006444
		[Register("onRequestNotFilled", "(Lcom/adcolony/sdk/AdColonyZone;)V", "GetOnRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_Handler")]
		public unsafe virtual void OnRequestNotFilled(AdColonyZone zone)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((zone == null) ? IntPtr.Zero : zone.Handle);
				AdColonyAdViewListener._members.InstanceMethods.InvokeVirtualVoidMethod("onRequestNotFilled.(Lcom/adcolony/sdk/AdColonyZone;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(zone);
			}
		}

		// Token: 0x0400006C RID: 108
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyAdViewListener", typeof(AdColonyAdViewListener));

		// Token: 0x0400006D RID: 109
		private static Delegate cb_onClicked_Lcom_adcolony_sdk_AdColonyAdView_;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_onClosed_Lcom_adcolony_sdk_AdColonyAdView_;

		// Token: 0x0400006F RID: 111
		private static Delegate cb_onLeftApplication_Lcom_adcolony_sdk_AdColonyAdView_;

		// Token: 0x04000070 RID: 112
		private static Delegate cb_onOpened_Lcom_adcolony_sdk_AdColonyAdView_;

		// Token: 0x04000071 RID: 113
		private static Delegate cb_onRequestFilled_Lcom_adcolony_sdk_AdColonyAdView_;

		// Token: 0x04000072 RID: 114
		private static Delegate cb_onRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_;
	}
}
