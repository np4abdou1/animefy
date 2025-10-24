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

namespace Com.Unity3d.Scar.Adapter.V1950.Scarads
{
	// Token: 0x02000273 RID: 627
	[Register("com/unity3d/scar/adapter/v1950/scarads/ScarAdBase", DoNotGenerateAcw = true)]
	public abstract class ScarAdBase : Java.Lang.Object, IScarAd, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x0005CFCC File Offset: 0x0005B1CC
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x0005CFFC File Offset: 0x0005B1FC
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

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x0005D048 File Offset: 0x0005B248
		// (set) Token: 0x0600235C RID: 9052 RVA: 0x0005D078 File Offset: 0x0005B278
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

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x0005D0C4 File Offset: 0x0005B2C4
		// (set) Token: 0x0600235E RID: 9054 RVA: 0x0005D0F4 File Offset: 0x0005B2F4
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

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x0005D140 File Offset: 0x0005B340
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x0005D164 File Offset: 0x0005B364
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdBase._members;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x0005D16C File Offset: 0x0005B36C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x0005D190 File Offset: 0x0005B390
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdBase._members.ManagedPeerType;
			}
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarAdBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x0005D19C File Offset: 0x0005B39C
		private static Delegate GetLoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdBase.n_LoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return ScarAdBase.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x0005D1C0 File Offset: 0x0005B3C0
		private static void n_LoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_loadListener)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_loadListener, JniHandleOwnership.DoNotTransfer);
			@object.LoadAd(object2);
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x0005D1E4 File Offset: 0x0005B3E4
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

		// Token: 0x06002367 RID: 9063 RVA: 0x0005D24C File Offset: 0x0005B44C
		private static Delegate GetShow_Landroid_app_Activity_Handler()
		{
			if (ScarAdBase.cb_show_Landroid_app_Activity_ == null)
			{
				ScarAdBase.cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdBase.n_Show_Landroid_app_Activity_));
			}
			return ScarAdBase.cb_show_Landroid_app_Activity_;
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x0005D270 File Offset: 0x0005B470
		private static void n_Show_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x06002369 RID: 9065
		[Register("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler")]
		public abstract void Show(Activity p0);

		// Token: 0x0400071A RID: 1818
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/scarads/ScarAdBase", typeof(ScarAdBase));

		// Token: 0x0400071B RID: 1819
		private static Delegate cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x0400071C RID: 1820
		private static Delegate cb_show_Landroid_app_Activity_;
	}
}
