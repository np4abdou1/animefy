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

namespace Com.Unity3d.Scar.Adapter.V1920.Scarads
{
	// Token: 0x0200028B RID: 651
	[Register("com/unity3d/scar/adapter/v1920/scarads/ScarAdBase", DoNotGenerateAcw = true)]
	public abstract class ScarAdBase : Java.Lang.Object, IScarAd, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x00060890 File Offset: 0x0005EA90
		// (set) Token: 0x0600257E RID: 9598 RVA: 0x000608C0 File Offset: 0x0005EAC0
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

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x0006090C File Offset: 0x0005EB0C
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x0006093C File Offset: 0x0005EB3C
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

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x00060988 File Offset: 0x0005EB88
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x000609B8 File Offset: 0x0005EBB8
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

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x00060A04 File Offset: 0x0005EC04
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x00060A28 File Offset: 0x0005EC28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdBase._members;
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x00060A30 File Offset: 0x0005EC30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x00060A54 File Offset: 0x0005EC54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdBase._members.ManagedPeerType;
			}
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarAdBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00060A60 File Offset: 0x0005EC60
		private static Delegate GetLoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdBase.n_LoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00060A84 File Offset: 0x0005EC84
		private static void n_LoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_loadListener)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_loadListener, JniHandleOwnership.DoNotTransfer);
			@object.LoadAd(object2);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00060AA8 File Offset: 0x0005ECA8
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

		// Token: 0x0600258B RID: 9611 RVA: 0x00060B10 File Offset: 0x0005ED10
		private static Delegate GetShow_Landroid_app_Activity_Handler()
		{
			if (ScarAdBase.cb_show_Landroid_app_Activity_ == null)
			{
				ScarAdBase.cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdBase.n_Show_Landroid_app_Activity_));
			}
			return ScarAdBase.cb_show_Landroid_app_Activity_;
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00060B34 File Offset: 0x0005ED34
		private static void n_Show_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x0600258D RID: 9613
		[Register("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler")]
		public abstract void Show(Activity p0);

		// Token: 0x04000742 RID: 1858
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/scarads/ScarAdBase", typeof(ScarAdBase));

		// Token: 0x04000743 RID: 1859
		private static Delegate cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x04000744 RID: 1860
		private static Delegate cb_show_Landroid_app_Activity_;
	}
}
