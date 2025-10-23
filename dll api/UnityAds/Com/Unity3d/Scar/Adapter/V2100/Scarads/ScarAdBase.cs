using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Com.Unity3d.Scar.Adapter.V2100.Requests;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2100.Scarads
{
	// Token: 0x02000246 RID: 582
	[Register("com/unity3d/scar/adapter/v2100/scarads/ScarAdBase", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class ScarAdBase : Java.Lang.Object, IScarAd, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x00054A74 File Offset: 0x00052C74
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x00054AA4 File Offset: 0x00052CA4
		[Register("_adObj")]
		protected Java.Lang.Object AdObj
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(ScarAdBase._members.InstanceFields.GetObjectValue("_adObj.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdBase._members.InstanceFields.SetValue("_adObj.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x00054AF0 File Offset: 0x00052CF0
		// (set) Token: 0x06001E50 RID: 7760 RVA: 0x00054B20 File Offset: 0x00052D20
		[Register("_adRequestFactory")]
		protected AdRequestFactory AdRequestFactory
		{
			get
			{
				return Java.Lang.Object.GetObject<AdRequestFactory>(ScarAdBase._members.InstanceFields.GetObjectValue("_adRequestFactory.Lcom/unity3d/scar/adapter/v2100/requests/AdRequestFactory;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdBase._members.InstanceFields.SetValue("_adRequestFactory.Lcom/unity3d/scar/adapter/v2100/requests/AdRequestFactory;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x00054B6C File Offset: 0x00052D6C
		// (set) Token: 0x06001E52 RID: 7762 RVA: 0x00054B9C File Offset: 0x00052D9C
		[Register("_adsErrorHandler")]
		protected IAdsErrorHandler AdsErrorHandler
		{
			get
			{
				return Java.Lang.Object.GetObject<IAdsErrorHandler>(ScarAdBase._members.InstanceFields.GetObjectValue("_adsErrorHandler.Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdBase._members.InstanceFields.SetValue("_adsErrorHandler.Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x00054BE8 File Offset: 0x00052DE8
		// (set) Token: 0x06001E54 RID: 7764 RVA: 0x00054C18 File Offset: 0x00052E18
		[Register("_context")]
		protected Context Context
		{
			get
			{
				return Java.Lang.Object.GetObject<Context>(ScarAdBase._members.InstanceFields.GetObjectValue("_context.Landroid/content/Context;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdBase._members.InstanceFields.SetValue("_context.Landroid/content/Context;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x00054C64 File Offset: 0x00052E64
		// (set) Token: 0x06001E56 RID: 7766 RVA: 0x00054C94 File Offset: 0x00052E94
		[Register("_scarAdListener")]
		protected ScarAdListener ScarAdListener
		{
			get
			{
				return Java.Lang.Object.GetObject<ScarAdListener>(ScarAdBase._members.InstanceFields.GetObjectValue("_scarAdListener.Lcom/unity3d/scar/adapter/v2100/scarads/ScarAdListener;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdBase._members.InstanceFields.SetValue("_scarAdListener.Lcom/unity3d/scar/adapter/v2100/scarads/ScarAdListener;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x00054CE0 File Offset: 0x00052EE0
		// (set) Token: 0x06001E58 RID: 7768 RVA: 0x00054D10 File Offset: 0x00052F10
		[Register("_scarAdMetadata")]
		protected ScarAdMetadata ScarAdMetadata
		{
			get
			{
				return Java.Lang.Object.GetObject<ScarAdMetadata>(ScarAdBase._members.InstanceFields.GetObjectValue("_scarAdMetadata.Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdBase._members.InstanceFields.SetValue("_scarAdMetadata.Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x00054D5C File Offset: 0x00052F5C
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00054D80 File Offset: 0x00052F80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdBase._members;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x00054D88 File Offset: 0x00052F88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x00054DAC File Offset: 0x00052FAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdBase._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarAdBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00054DB8 File Offset: 0x00052FB8
		[Register(".ctor", "(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/v2100/requests/AdRequestFactory;Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)V", "")]
		public unsafe ScarAdBase(Context context, ScarAdMetadata scarAdMetadata, AdRequestFactory adRequestFactory, IAdsErrorHandler adsErrorHandler) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((scarAdMetadata == null) ? IntPtr.Zero : scarAdMetadata.Handle);
				ptr[2] = new JniArgumentValue((adRequestFactory == null) ? IntPtr.Zero : adRequestFactory.Handle);
				ptr[3] = new JniArgumentValue((adsErrorHandler == null) ? IntPtr.Zero : ((Java.Lang.Object)adsErrorHandler).Handle);
				base.SetHandle(ScarAdBase._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/v2100/requests/AdRequestFactory;Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScarAdBase._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/scar/adapter/v2100/requests/AdRequestFactory;Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(scarAdMetadata);
				GC.KeepAlive(adRequestFactory);
				GC.KeepAlive(adsErrorHandler);
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00054EEC File Offset: 0x000530EC
		private static Delegate GetLoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdBase.n_LoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00054F10 File Offset: 0x00053110
		private static void n_LoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_loadListener)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_loadListener, JniHandleOwnership.DoNotTransfer);
			@object.LoadAd(object2);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00054F34 File Offset: 0x00053134
		[Register("loadAd", "(Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;)V", "GetLoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler")]
		public unsafe virtual void LoadAd(IScarLoadListener loadListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((loadListener == null) ? IntPtr.Zero : ((Java.Lang.Object)loadListener).Handle);
				ScarAdBase._members.InstanceMethods.InvokeVirtualVoidMethod("loadAd.(Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(loadListener);
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00054F9C File Offset: 0x0005319C
		private static Delegate GetSetGmaAd_Ljava_lang_Object_Handler()
		{
			if (ScarAdBase.cb_setGmaAd_Ljava_lang_Object_ == null)
			{
				ScarAdBase.cb_setGmaAd_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdBase.n_SetGmaAd_Ljava_lang_Object_));
			}
			return ScarAdBase.cb_setGmaAd_Ljava_lang_Object_;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00054FC0 File Offset: 0x000531C0
		private static void n_SetGmaAd_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_rewardedAd)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_rewardedAd, JniHandleOwnership.DoNotTransfer);
			@object.SetGmaAd(object2);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00054FE4 File Offset: 0x000531E4
		[Register("setGmaAd", "(Ljava/lang/Object;)V", "GetSetGmaAd_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetGmaAd(Java.Lang.Object rewardedAd)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(rewardedAd);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ScarAdBase._members.InstanceMethods.InvokeVirtualVoidMethod("setGmaAd.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(rewardedAd);
			}
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00055048 File Offset: 0x00053248
		private static Delegate GetShow_Landroid_app_Activity_Handler()
		{
			if (ScarAdBase.cb_show_Landroid_app_Activity_ == null)
			{
				ScarAdBase.cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdBase.n_Show_Landroid_app_Activity_));
			}
			return ScarAdBase.cb_show_Landroid_app_Activity_;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0005506C File Offset: 0x0005326C
		private static void n_Show_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x06001E67 RID: 7783
		[Register("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler")]
		public abstract void Show(Activity p0);

		// Token: 0x040006D5 RID: 1749
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/scarads/ScarAdBase", typeof(ScarAdBase));

		// Token: 0x040006D6 RID: 1750
		private static Delegate cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x040006D7 RID: 1751
		private static Delegate cb_setGmaAd_Ljava_lang_Object_;

		// Token: 0x040006D8 RID: 1752
		private static Delegate cb_show_Landroid_app_Activity_;
	}
}
