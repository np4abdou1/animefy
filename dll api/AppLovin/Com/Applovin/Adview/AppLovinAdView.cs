using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Adview
{
	// Token: 0x0200017C RID: 380
	[Register("com/applovin/adview/AppLovinAdView", DoNotGenerateAcw = true)]
	public class AppLovinAdView : RelativeLayout
	{
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00034264 File Offset: 0x00032464
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinAdView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00034288 File Offset: 0x00032488
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinAdView._members;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x00034290 File Offset: 0x00032490
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinAdView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000342B4 File Offset: 0x000324B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinAdView._members.ManagedPeerType;
			}
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00016D4C File Offset: 0x00014F4C
		protected AppLovinAdView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x000342C0 File Offset: 0x000324C0
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AppLovinAdView(Context p0, IAttributeSet p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				base.SetHandle(AppLovinAdView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinAdView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0003439C File Offset: 0x0003259C
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AppLovinAdView(Context p0, IAttributeSet p1, int p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JniArgumentValue(p2);
				base.SetHandle(AppLovinAdView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinAdView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0003448C File Offset: 0x0003268C
		[Register(".ctor", "(Lcom/applovin/sdk/AppLovinAdSize;Landroid/content/Context;)V", "")]
		public unsafe AppLovinAdView(AppLovinAdSize p0, Context p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				base.SetHandle(AppLovinAdView._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/sdk/AppLovinAdSize;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinAdView._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/sdk/AppLovinAdSize;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00034564 File Offset: 0x00032764
		[Register(".ctor", "(Lcom/applovin/sdk/AppLovinAdSize;Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe AppLovinAdView(AppLovinAdSize p0, string p1, Context p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				base.SetHandle(AppLovinAdView._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/sdk/AppLovinAdSize;Ljava/lang/String;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinAdView._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/sdk/AppLovinAdSize;Ljava/lang/String;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0003465C File Offset: 0x0003285C
		[Register(".ctor", "(Lcom/applovin/sdk/AppLovinSdk;Lcom/applovin/sdk/AppLovinAdSize;Landroid/content/Context;)V", "")]
		public unsafe AppLovinAdView(AppLovinSdk p0, AppLovinAdSize p1, Context p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				base.SetHandle(AppLovinAdView._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;Lcom/applovin/sdk/AppLovinAdSize;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinAdView._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;Lcom/applovin/sdk/AppLovinAdSize;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0003475C File Offset: 0x0003295C
		[Register(".ctor", "(Lcom/applovin/sdk/AppLovinSdk;Lcom/applovin/sdk/AppLovinAdSize;Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe AppLovinAdView(AppLovinSdk p0, AppLovinAdSize p1, string p2, Context p3) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : p3.Handle);
				base.SetHandle(AppLovinAdView._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;Lcom/applovin/sdk/AppLovinAdSize;Ljava/lang/String;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinAdView._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;Lcom/applovin/sdk/AppLovinAdSize;Ljava/lang/String;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p3);
			}
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00034884 File Offset: 0x00032A84
		private static Delegate GetGetSizeHandler()
		{
			if (AppLovinAdView.cb_getSize == null)
			{
				AppLovinAdView.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdView.n_GetSize));
			}
			return AppLovinAdView.cb_getSize;
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x000348A8 File Offset: 0x00032AA8
		private static IntPtr n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size);
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x000348BC File Offset: 0x00032ABC
		public virtual AppLovinAdSize Size
		{
			[Register("getSize", "()Lcom/applovin/sdk/AppLovinAdSize;", "GetGetSizeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdSize>(AppLovinAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getSize.()Lcom/applovin/sdk/AppLovinAdSize;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x000348EE File Offset: 0x00032AEE
		private static Delegate GetGetZoneIdHandler()
		{
			if (AppLovinAdView.cb_getZoneId == null)
			{
				AppLovinAdView.cb_getZoneId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdView.n_GetZoneId));
			}
			return AppLovinAdView.cb_getZoneId;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00034912 File Offset: 0x00032B12
		private static IntPtr n_GetZoneId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ZoneId);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00034928 File Offset: 0x00032B28
		public virtual string ZoneId
		{
			[Register("getZoneId", "()Ljava/lang/String;", "GetGetZoneIdHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getZoneId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0003495A File Offset: 0x00032B5A
		private static Delegate GetDestroyHandler()
		{
			if (AppLovinAdView.cb_destroy == null)
			{
				AppLovinAdView.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinAdView.n_Destroy));
			}
			return AppLovinAdView.cb_destroy;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0003497E File Offset: 0x00032B7E
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0003498D File Offset: 0x00032B8D
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			AppLovinAdView._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000349A6 File Offset: 0x00032BA6
		private static Delegate GetLoadNextAdHandler()
		{
			if (AppLovinAdView.cb_loadNextAd == null)
			{
				AppLovinAdView.cb_loadNextAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinAdView.n_LoadNextAd));
			}
			return AppLovinAdView.cb_loadNextAd;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000349CA File Offset: 0x00032BCA
		private static void n_LoadNextAd(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadNextAd();
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000349D9 File Offset: 0x00032BD9
		[Register("loadNextAd", "()V", "GetLoadNextAdHandler")]
		public virtual void LoadNextAd()
		{
			AppLovinAdView._members.InstanceMethods.InvokeVirtualVoidMethod("loadNextAd.()V", this, null);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x000349F2 File Offset: 0x00032BF2
		private static Delegate GetPauseHandler()
		{
			if (AppLovinAdView.cb_pause == null)
			{
				AppLovinAdView.cb_pause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinAdView.n_Pause));
			}
			return AppLovinAdView.cb_pause;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00034A16 File Offset: 0x00032C16
		private static void n_Pause(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pause();
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00034A25 File Offset: 0x00032C25
		[Register("pause", "()V", "GetPauseHandler")]
		public virtual void Pause()
		{
			AppLovinAdView._members.InstanceMethods.InvokeVirtualVoidMethod("pause.()V", this, null);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00034A3E File Offset: 0x00032C3E
		private static Delegate GetRenderAd_Lcom_applovin_sdk_AppLovinAd_Handler()
		{
			if (AppLovinAdView.cb_renderAd_Lcom_applovin_sdk_AppLovinAd_ == null)
			{
				AppLovinAdView.cb_renderAd_Lcom_applovin_sdk_AppLovinAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinAdView.n_RenderAd_Lcom_applovin_sdk_AppLovinAd_));
			}
			return AppLovinAdView.cb_renderAd_Lcom_applovin_sdk_AppLovinAd_;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00034A64 File Offset: 0x00032C64
		private static void n_RenderAd_Lcom_applovin_sdk_AppLovinAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinAdView @object = Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RenderAd(object2);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00034A88 File Offset: 0x00032C88
		[Register("renderAd", "(Lcom/applovin/sdk/AppLovinAd;)V", "GetRenderAd_Lcom_applovin_sdk_AppLovinAd_Handler")]
		public unsafe virtual void RenderAd(IAppLovinAd p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinAdView._members.InstanceMethods.InvokeVirtualVoidMethod("renderAd.(Lcom/applovin/sdk/AppLovinAd;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00034AF0 File Offset: 0x00032CF0
		private static Delegate GetResumeHandler()
		{
			if (AppLovinAdView.cb_resume == null)
			{
				AppLovinAdView.cb_resume = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinAdView.n_Resume));
			}
			return AppLovinAdView.cb_resume;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00034B14 File Offset: 0x00032D14
		private static void n_Resume(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Resume();
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00034B23 File Offset: 0x00032D23
		[Register("resume", "()V", "GetResumeHandler")]
		public virtual void Resume()
		{
			AppLovinAdView._members.InstanceMethods.InvokeVirtualVoidMethod("resume.()V", this, null);
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00034B3C File Offset: 0x00032D3C
		private static Delegate GetSetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_Handler()
		{
			if (AppLovinAdView.cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_ == null)
			{
				AppLovinAdView.cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinAdView.n_SetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_));
			}
			return AppLovinAdView.cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00034B60 File Offset: 0x00032D60
		private static void n_SetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinAdView @object = Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdClickListener object2 = Java.Lang.Object.GetObject<IAppLovinAdClickListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdClickListener(object2);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00034B84 File Offset: 0x00032D84
		[Register("setAdClickListener", "(Lcom/applovin/sdk/AppLovinAdClickListener;)V", "GetSetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_Handler")]
		public unsafe virtual void SetAdClickListener(IAppLovinAdClickListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setAdClickListener.(Lcom/applovin/sdk/AppLovinAdClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00034BEC File Offset: 0x00032DEC
		private static Delegate GetSetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Handler()
		{
			if (AppLovinAdView.cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_ == null)
			{
				AppLovinAdView.cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinAdView.n_SetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_));
			}
			return AppLovinAdView.cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00034C10 File Offset: 0x00032E10
		private static void n_SetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinAdView @object = Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdDisplayListener object2 = Java.Lang.Object.GetObject<IAppLovinAdDisplayListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdDisplayListener(object2);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00034C34 File Offset: 0x00032E34
		[Register("setAdDisplayListener", "(Lcom/applovin/sdk/AppLovinAdDisplayListener;)V", "GetSetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Handler")]
		public unsafe virtual void SetAdDisplayListener(IAppLovinAdDisplayListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setAdDisplayListener.(Lcom/applovin/sdk/AppLovinAdDisplayListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00034C9C File Offset: 0x00032E9C
		private static Delegate GetSetAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (AppLovinAdView.cb_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				AppLovinAdView.cb_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinAdView.n_SetAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return AppLovinAdView.cb_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00034CC0 File Offset: 0x00032EC0
		private static void n_SetAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinAdView @object = Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdLoadListener(object2);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00034CE4 File Offset: 0x00032EE4
		[Register("setAdLoadListener", "(Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetSetAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler")]
		public unsafe virtual void SetAdLoadListener(IAppLovinAdLoadListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setAdLoadListener.(Lcom/applovin/sdk/AppLovinAdLoadListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00034D4C File Offset: 0x00032F4C
		private static Delegate GetSetAdViewEventListener_Lcom_applovin_adview_AppLovinAdViewEventListener_Handler()
		{
			if (AppLovinAdView.cb_setAdViewEventListener_Lcom_applovin_adview_AppLovinAdViewEventListener_ == null)
			{
				AppLovinAdView.cb_setAdViewEventListener_Lcom_applovin_adview_AppLovinAdViewEventListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinAdView.n_SetAdViewEventListener_Lcom_applovin_adview_AppLovinAdViewEventListener_));
			}
			return AppLovinAdView.cb_setAdViewEventListener_Lcom_applovin_adview_AppLovinAdViewEventListener_;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00034D70 File Offset: 0x00032F70
		private static void n_SetAdViewEventListener_Lcom_applovin_adview_AppLovinAdViewEventListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinAdView @object = Java.Lang.Object.GetObject<AppLovinAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdViewEventListener object2 = Java.Lang.Object.GetObject<IAppLovinAdViewEventListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdViewEventListener(object2);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00034D94 File Offset: 0x00032F94
		[Register("setAdViewEventListener", "(Lcom/applovin/adview/AppLovinAdViewEventListener;)V", "GetSetAdViewEventListener_Lcom_applovin_adview_AppLovinAdViewEventListener_Handler")]
		public unsafe virtual void SetAdViewEventListener(IAppLovinAdViewEventListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setAdViewEventListener.(Lcom/applovin/adview/AppLovinAdViewEventListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600124F RID: 4687 RVA: 0x00034DFC File Offset: 0x00032FFC
		// (remove) Token: 0x06001250 RID: 4688 RVA: 0x00034E48 File Offset: 0x00033048
		public event EventHandler<AppLovinAdClickEventArgs> AdClick
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdClickListener, IAppLovinAdClickListenerImplementor>(ref this.weak_implementor_SetAdClickListener, new Func<IAppLovinAdClickListenerImplementor>(this.__CreateIAppLovinAdClickListenerImplementor), new Action<IAppLovinAdClickListener>(this.SetAdClickListener), delegate(IAppLovinAdClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppLovinAdClickEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdClickListener, IAppLovinAdClickListenerImplementor>(ref this.weak_implementor_SetAdClickListener, new Func<IAppLovinAdClickListenerImplementor, bool>(IAppLovinAdClickListenerImplementor.__IsEmpty), delegate(IAppLovinAdClickListener __v)
				{
					this.SetAdClickListener(null);
				}, delegate(IAppLovinAdClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppLovinAdClickEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0003266C File Offset: 0x0003086C
		private IAppLovinAdClickListenerImplementor __CreateIAppLovinAdClickListenerImplementor()
		{
			return new IAppLovinAdClickListenerImplementor(this);
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06001252 RID: 4690 RVA: 0x00034E98 File Offset: 0x00033098
		// (remove) Token: 0x06001253 RID: 4691 RVA: 0x00034EE4 File Offset: 0x000330E4
		public event EventHandler<AdDisplayedEventArgs> AdDisplayed
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdDisplayListener, IAppLovinAdDisplayListenerImplementor>(ref this.weak_implementor_SetAdDisplayListener, new Func<IAppLovinAdDisplayListenerImplementor>(this.__CreateIAppLovinAdDisplayListenerImplementor), new Action<IAppLovinAdDisplayListener>(this.SetAdDisplayListener), delegate(IAppLovinAdDisplayListenerImplementor __h)
				{
					__h.AdDisplayedHandler = (EventHandler<AdDisplayedEventArgs>)Delegate.Combine(__h.AdDisplayedHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdDisplayListener, IAppLovinAdDisplayListenerImplementor>(ref this.weak_implementor_SetAdDisplayListener, new Func<IAppLovinAdDisplayListenerImplementor, bool>(IAppLovinAdDisplayListenerImplementor.__IsEmpty), delegate(IAppLovinAdDisplayListener __v)
				{
					this.SetAdDisplayListener(null);
				}, delegate(IAppLovinAdDisplayListenerImplementor __h)
				{
					__h.AdDisplayedHandler = (EventHandler<AdDisplayedEventArgs>)Delegate.Remove(__h.AdDisplayedHandler, value);
				});
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06001254 RID: 4692 RVA: 0x00034F34 File Offset: 0x00033134
		// (remove) Token: 0x06001255 RID: 4693 RVA: 0x00034F80 File Offset: 0x00033180
		public event EventHandler<AdHiddenEventArgs> AdHidden
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdDisplayListener, IAppLovinAdDisplayListenerImplementor>(ref this.weak_implementor_SetAdDisplayListener, new Func<IAppLovinAdDisplayListenerImplementor>(this.__CreateIAppLovinAdDisplayListenerImplementor), new Action<IAppLovinAdDisplayListener>(this.SetAdDisplayListener), delegate(IAppLovinAdDisplayListenerImplementor __h)
				{
					__h.AdHiddenHandler = (EventHandler<AdHiddenEventArgs>)Delegate.Combine(__h.AdHiddenHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdDisplayListener, IAppLovinAdDisplayListenerImplementor>(ref this.weak_implementor_SetAdDisplayListener, new Func<IAppLovinAdDisplayListenerImplementor, bool>(IAppLovinAdDisplayListenerImplementor.__IsEmpty), delegate(IAppLovinAdDisplayListener __v)
				{
					this.SetAdDisplayListener(null);
				}, delegate(IAppLovinAdDisplayListenerImplementor __h)
				{
					__h.AdHiddenHandler = (EventHandler<AdHiddenEventArgs>)Delegate.Remove(__h.AdHiddenHandler, value);
				});
			}
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000327AC File Offset: 0x000309AC
		private IAppLovinAdDisplayListenerImplementor __CreateIAppLovinAdDisplayListenerImplementor()
		{
			return new IAppLovinAdDisplayListenerImplementor(this);
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06001257 RID: 4695 RVA: 0x00034FD0 File Offset: 0x000331D0
		// (remove) Token: 0x06001258 RID: 4696 RVA: 0x0003501C File Offset: 0x0003321C
		public event EventHandler<AdReceivedEventArgs> AdReceived
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdLoadListener, IAppLovinAdLoadListenerImplementor>(ref this.weak_implementor_SetAdLoadListener, new Func<IAppLovinAdLoadListenerImplementor>(this.__CreateIAppLovinAdLoadListenerImplementor), new Action<IAppLovinAdLoadListener>(this.SetAdLoadListener), delegate(IAppLovinAdLoadListenerImplementor __h)
				{
					__h.AdReceivedHandler = (EventHandler<AdReceivedEventArgs>)Delegate.Combine(__h.AdReceivedHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdLoadListener, IAppLovinAdLoadListenerImplementor>(ref this.weak_implementor_SetAdLoadListener, new Func<IAppLovinAdLoadListenerImplementor, bool>(IAppLovinAdLoadListenerImplementor.__IsEmpty), delegate(IAppLovinAdLoadListener __v)
				{
					this.SetAdLoadListener(null);
				}, delegate(IAppLovinAdLoadListenerImplementor __h)
				{
					__h.AdReceivedHandler = (EventHandler<AdReceivedEventArgs>)Delegate.Remove(__h.AdReceivedHandler, value);
				});
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06001259 RID: 4697 RVA: 0x0003506C File Offset: 0x0003326C
		// (remove) Token: 0x0600125A RID: 4698 RVA: 0x000350B8 File Offset: 0x000332B8
		public event EventHandler<FailedToReceiveAdEventArgs> FailedToReceiveAd
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdLoadListener, IAppLovinAdLoadListenerImplementor>(ref this.weak_implementor_SetAdLoadListener, new Func<IAppLovinAdLoadListenerImplementor>(this.__CreateIAppLovinAdLoadListenerImplementor), new Action<IAppLovinAdLoadListener>(this.SetAdLoadListener), delegate(IAppLovinAdLoadListenerImplementor __h)
				{
					__h.FailedToReceiveAdHandler = (EventHandler<FailedToReceiveAdEventArgs>)Delegate.Combine(__h.FailedToReceiveAdHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdLoadListener, IAppLovinAdLoadListenerImplementor>(ref this.weak_implementor_SetAdLoadListener, new Func<IAppLovinAdLoadListenerImplementor, bool>(IAppLovinAdLoadListenerImplementor.__IsEmpty), delegate(IAppLovinAdLoadListener __v)
				{
					this.SetAdLoadListener(null);
				}, delegate(IAppLovinAdLoadListenerImplementor __h)
				{
					__h.FailedToReceiveAdHandler = (EventHandler<FailedToReceiveAdEventArgs>)Delegate.Remove(__h.FailedToReceiveAdHandler, value);
				});
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00035108 File Offset: 0x00033308
		private IAppLovinAdLoadListenerImplementor __CreateIAppLovinAdLoadListenerImplementor()
		{
			return new IAppLovinAdLoadListenerImplementor(this);
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600125C RID: 4700 RVA: 0x00035110 File Offset: 0x00033310
		// (remove) Token: 0x0600125D RID: 4701 RVA: 0x0003515C File Offset: 0x0003335C
		public event EventHandler<AdClosedFullscreenEventArgs> AdClosedFullscreen
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdViewEventListener, IAppLovinAdViewEventListenerImplementor>(ref this.weak_implementor_SetAdViewEventListener, new Func<IAppLovinAdViewEventListenerImplementor>(this.__CreateIAppLovinAdViewEventListenerImplementor), new Action<IAppLovinAdViewEventListener>(this.SetAdViewEventListener), delegate(IAppLovinAdViewEventListenerImplementor __h)
				{
					__h.AdClosedFullscreenHandler = (EventHandler<AdClosedFullscreenEventArgs>)Delegate.Combine(__h.AdClosedFullscreenHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdViewEventListener, IAppLovinAdViewEventListenerImplementor>(ref this.weak_implementor_SetAdViewEventListener, new Func<IAppLovinAdViewEventListenerImplementor, bool>(IAppLovinAdViewEventListenerImplementor.__IsEmpty), delegate(IAppLovinAdViewEventListener __v)
				{
					this.SetAdViewEventListener(null);
				}, delegate(IAppLovinAdViewEventListenerImplementor __h)
				{
					__h.AdClosedFullscreenHandler = (EventHandler<AdClosedFullscreenEventArgs>)Delegate.Remove(__h.AdClosedFullscreenHandler, value);
				});
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600125E RID: 4702 RVA: 0x000351AC File Offset: 0x000333AC
		// (remove) Token: 0x0600125F RID: 4703 RVA: 0x000351F8 File Offset: 0x000333F8
		public event EventHandler<AdFailedToDisplayEventArgs> AdFailedToDisplay
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdViewEventListener, IAppLovinAdViewEventListenerImplementor>(ref this.weak_implementor_SetAdViewEventListener, new Func<IAppLovinAdViewEventListenerImplementor>(this.__CreateIAppLovinAdViewEventListenerImplementor), new Action<IAppLovinAdViewEventListener>(this.SetAdViewEventListener), delegate(IAppLovinAdViewEventListenerImplementor __h)
				{
					__h.AdFailedToDisplayHandler = (EventHandler<AdFailedToDisplayEventArgs>)Delegate.Combine(__h.AdFailedToDisplayHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdViewEventListener, IAppLovinAdViewEventListenerImplementor>(ref this.weak_implementor_SetAdViewEventListener, new Func<IAppLovinAdViewEventListenerImplementor, bool>(IAppLovinAdViewEventListenerImplementor.__IsEmpty), delegate(IAppLovinAdViewEventListener __v)
				{
					this.SetAdViewEventListener(null);
				}, delegate(IAppLovinAdViewEventListenerImplementor __h)
				{
					__h.AdFailedToDisplayHandler = (EventHandler<AdFailedToDisplayEventArgs>)Delegate.Remove(__h.AdFailedToDisplayHandler, value);
				});
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06001260 RID: 4704 RVA: 0x00035248 File Offset: 0x00033448
		// (remove) Token: 0x06001261 RID: 4705 RVA: 0x00035294 File Offset: 0x00033494
		public event EventHandler<AdLeftApplicationEventArgs> AdLeftApplication
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdViewEventListener, IAppLovinAdViewEventListenerImplementor>(ref this.weak_implementor_SetAdViewEventListener, new Func<IAppLovinAdViewEventListenerImplementor>(this.__CreateIAppLovinAdViewEventListenerImplementor), new Action<IAppLovinAdViewEventListener>(this.SetAdViewEventListener), delegate(IAppLovinAdViewEventListenerImplementor __h)
				{
					__h.AdLeftApplicationHandler = (EventHandler<AdLeftApplicationEventArgs>)Delegate.Combine(__h.AdLeftApplicationHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdViewEventListener, IAppLovinAdViewEventListenerImplementor>(ref this.weak_implementor_SetAdViewEventListener, new Func<IAppLovinAdViewEventListenerImplementor, bool>(IAppLovinAdViewEventListenerImplementor.__IsEmpty), delegate(IAppLovinAdViewEventListener __v)
				{
					this.SetAdViewEventListener(null);
				}, delegate(IAppLovinAdViewEventListenerImplementor __h)
				{
					__h.AdLeftApplicationHandler = (EventHandler<AdLeftApplicationEventArgs>)Delegate.Remove(__h.AdLeftApplicationHandler, value);
				});
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06001262 RID: 4706 RVA: 0x000352E4 File Offset: 0x000334E4
		// (remove) Token: 0x06001263 RID: 4707 RVA: 0x00035330 File Offset: 0x00033530
		public event EventHandler<AdOpenedFullscreenEventArgs> AdOpenedFullscreen
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdViewEventListener, IAppLovinAdViewEventListenerImplementor>(ref this.weak_implementor_SetAdViewEventListener, new Func<IAppLovinAdViewEventListenerImplementor>(this.__CreateIAppLovinAdViewEventListenerImplementor), new Action<IAppLovinAdViewEventListener>(this.SetAdViewEventListener), delegate(IAppLovinAdViewEventListenerImplementor __h)
				{
					__h.AdOpenedFullscreenHandler = (EventHandler<AdOpenedFullscreenEventArgs>)Delegate.Combine(__h.AdOpenedFullscreenHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdViewEventListener, IAppLovinAdViewEventListenerImplementor>(ref this.weak_implementor_SetAdViewEventListener, new Func<IAppLovinAdViewEventListenerImplementor, bool>(IAppLovinAdViewEventListenerImplementor.__IsEmpty), delegate(IAppLovinAdViewEventListener __v)
				{
					this.SetAdViewEventListener(null);
				}, delegate(IAppLovinAdViewEventListenerImplementor __h)
				{
					__h.AdOpenedFullscreenHandler = (EventHandler<AdOpenedFullscreenEventArgs>)Delegate.Remove(__h.AdOpenedFullscreenHandler, value);
				});
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00035380 File Offset: 0x00033580
		private IAppLovinAdViewEventListenerImplementor __CreateIAppLovinAdViewEventListenerImplementor()
		{
			return new IAppLovinAdViewEventListenerImplementor(this);
		}

		// Token: 0x040005EC RID: 1516
		[Register("NAMESPACE")]
		public const string Namespace = "http://schemas.applovin.com/android/1.0";

		// Token: 0x040005ED RID: 1517
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/adview/AppLovinAdView", typeof(AppLovinAdView));

		// Token: 0x040005EE RID: 1518
		private static Delegate cb_getSize;

		// Token: 0x040005EF RID: 1519
		private static Delegate cb_getZoneId;

		// Token: 0x040005F0 RID: 1520
		private static Delegate cb_destroy;

		// Token: 0x040005F1 RID: 1521
		private static Delegate cb_loadNextAd;

		// Token: 0x040005F2 RID: 1522
		private static Delegate cb_pause;

		// Token: 0x040005F3 RID: 1523
		private static Delegate cb_renderAd_Lcom_applovin_sdk_AppLovinAd_;

		// Token: 0x040005F4 RID: 1524
		private static Delegate cb_resume;

		// Token: 0x040005F5 RID: 1525
		private static Delegate cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_;

		// Token: 0x040005F6 RID: 1526
		private static Delegate cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_;

		// Token: 0x040005F7 RID: 1527
		private static Delegate cb_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x040005F8 RID: 1528
		private static Delegate cb_setAdViewEventListener_Lcom_applovin_adview_AppLovinAdViewEventListener_;

		// Token: 0x040005F9 RID: 1529
		private WeakReference weak_implementor_SetAdClickListener;

		// Token: 0x040005FA RID: 1530
		private WeakReference weak_implementor_SetAdDisplayListener;

		// Token: 0x040005FB RID: 1531
		private WeakReference weak_implementor_SetAdLoadListener;

		// Token: 0x040005FC RID: 1532
		private WeakReference weak_implementor_SetAdViewEventListener;
	}
}
