using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2000.Scarads
{
	// Token: 0x0200025D RID: 605
	[Register("com/unity3d/scar/adapter/v2000/scarads/ScarAdBase", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class ScarAdBase : Java.Lang.Object, IScarAd, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x00058E90 File Offset: 0x00057090
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x00058EC0 File Offset: 0x000570C0
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

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x00058F0C File Offset: 0x0005710C
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x00058F3C File Offset: 0x0005713C
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

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x00058F88 File Offset: 0x00057188
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x00058FB8 File Offset: 0x000571B8
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

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x00059004 File Offset: 0x00057204
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x00059034 File Offset: 0x00057234
		[Register("_scarAdListener")]
		protected ScarAdListener ScarAdListener
		{
			get
			{
				return Java.Lang.Object.GetObject<ScarAdListener>(ScarAdBase._members.InstanceFields.GetObjectValue("_scarAdListener.Lcom/unity3d/scar/adapter/v2000/scarads/ScarAdListener;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdBase._members.InstanceFields.SetValue("_scarAdListener.Lcom/unity3d/scar/adapter/v2000/scarads/ScarAdListener;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x00059080 File Offset: 0x00057280
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x000590B0 File Offset: 0x000572B0
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

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x000590FC File Offset: 0x000572FC
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x00059120 File Offset: 0x00057320
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdBase._members;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x00059128 File Offset: 0x00057328
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x0005914C File Offset: 0x0005734C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdBase._members.ManagedPeerType;
			}
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarAdBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00059158 File Offset: 0x00057358
		private static Delegate GetLoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdBase.n_LoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x0005917C File Offset: 0x0005737C
		private static void n_LoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_loadListener)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_loadListener, JniHandleOwnership.DoNotTransfer);
			@object.LoadAd(object2);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x000591A0 File Offset: 0x000573A0
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

		// Token: 0x060020EA RID: 8426 RVA: 0x00059208 File Offset: 0x00057408
		private static Delegate GetSetGmaAd_Ljava_lang_Object_Handler()
		{
			if (ScarAdBase.cb_setGmaAd_Ljava_lang_Object_ == null)
			{
				ScarAdBase.cb_setGmaAd_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdBase.n_SetGmaAd_Ljava_lang_Object_));
			}
			return ScarAdBase.cb_setGmaAd_Ljava_lang_Object_;
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0005922C File Offset: 0x0005742C
		private static void n_SetGmaAd_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_rewardedAd)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_rewardedAd, JniHandleOwnership.DoNotTransfer);
			@object.SetGmaAd(object2);
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00059250 File Offset: 0x00057450
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

		// Token: 0x060020ED RID: 8429 RVA: 0x000592B4 File Offset: 0x000574B4
		private static Delegate GetShow_Landroid_app_Activity_Handler()
		{
			if (ScarAdBase.cb_show_Landroid_app_Activity_ == null)
			{
				ScarAdBase.cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdBase.n_Show_Landroid_app_Activity_));
			}
			return ScarAdBase.cb_show_Landroid_app_Activity_;
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000592D8 File Offset: 0x000574D8
		private static void n_Show_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x060020EF RID: 8431
		[Register("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler")]
		public abstract void Show(Activity p0);

		// Token: 0x040006F8 RID: 1784
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/scarads/ScarAdBase", typeof(ScarAdBase));

		// Token: 0x040006F9 RID: 1785
		private static Delegate cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x040006FA RID: 1786
		private static Delegate cb_setGmaAd_Ljava_lang_Object_;

		// Token: 0x040006FB RID: 1787
		private static Delegate cb_show_Landroid_app_Activity_;
	}
}
