using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Services.Ads.Gmascar.Finder;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Adapters
{
	// Token: 0x0200021D RID: 541
	[Register("com/unity3d/services/ads/gmascar/adapters/ScarAdapterFactory", DoNotGenerateAcw = true)]
	public class ScarAdapterFactory : Java.Lang.Object
	{
		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00048CD8 File Offset: 0x00046ED8
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdapterFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00048CFC File Offset: 0x00046EFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdapterFactory._members;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00048D04 File Offset: 0x00046F04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdapterFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x00048D28 File Offset: 0x00046F28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdapterFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarAdapterFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00048D34 File Offset: 0x00046F34
		[Register(".ctor", "()V", "")]
		public ScarAdapterFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ScarAdapterFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ScarAdapterFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00048DA2 File Offset: 0x00046FA2
		private static Delegate GetCreateScarAdapter_Lcom_unity3d_services_ads_gmascar_finder_ScarAdapterVersion_Lcom_unity3d_scar_adapter_common_IAdsErrorHandler_Handler()
		{
			if (ScarAdapterFactory.cb_createScarAdapter_Lcom_unity3d_services_ads_gmascar_finder_ScarAdapterVersion_Lcom_unity3d_scar_adapter_common_IAdsErrorHandler_ == null)
			{
				ScarAdapterFactory.cb_createScarAdapter_Lcom_unity3d_services_ads_gmascar_finder_ScarAdapterVersion_Lcom_unity3d_scar_adapter_common_IAdsErrorHandler_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ScarAdapterFactory.n_CreateScarAdapter_Lcom_unity3d_services_ads_gmascar_finder_ScarAdapterVersion_Lcom_unity3d_scar_adapter_common_IAdsErrorHandler_));
			}
			return ScarAdapterFactory.cb_createScarAdapter_Lcom_unity3d_services_ads_gmascar_finder_ScarAdapterVersion_Lcom_unity3d_scar_adapter_common_IAdsErrorHandler_;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00048DC8 File Offset: 0x00046FC8
		private static IntPtr n_CreateScarAdapter_Lcom_unity3d_services_ads_gmascar_finder_ScarAdapterVersion_Lcom_unity3d_scar_adapter_common_IAdsErrorHandler_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapterVersion, IntPtr native_adsErrorHandler)
		{
			ScarAdapterFactory @object = Java.Lang.Object.GetObject<ScarAdapterFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ScarAdapterVersion object2 = Java.Lang.Object.GetObject<ScarAdapterVersion>(native_adapterVersion, JniHandleOwnership.DoNotTransfer);
			IAdsErrorHandler object3 = Java.Lang.Object.GetObject<IAdsErrorHandler>(native_adsErrorHandler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateScarAdapter(object2, object3));
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00048DFC File Offset: 0x00046FFC
		[Register("createScarAdapter", "(Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)Lcom/unity3d/scar/adapter/common/IScarAdapter;", "GetCreateScarAdapter_Lcom_unity3d_services_ads_gmascar_finder_ScarAdapterVersion_Lcom_unity3d_scar_adapter_common_IAdsErrorHandler_Handler")]
		public unsafe virtual IScarAdapter CreateScarAdapter(ScarAdapterVersion adapterVersion, IAdsErrorHandler adsErrorHandler)
		{
			IScarAdapter @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapterVersion == null) ? IntPtr.Zero : adapterVersion.Handle);
				ptr[1] = new JniArgumentValue((adsErrorHandler == null) ? IntPtr.Zero : ((Java.Lang.Object)adsErrorHandler).Handle);
				@object = Java.Lang.Object.GetObject<IScarAdapter>(ScarAdapterFactory._members.InstanceMethods.InvokeVirtualObjectMethod("createScarAdapter.(Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;Lcom/unity3d/scar/adapter/common/IAdsErrorHandler;)Lcom/unity3d/scar/adapter/common/IScarAdapter;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(adapterVersion);
				GC.KeepAlive(adsErrorHandler);
			}
			return @object;
		}

		// Token: 0x04000641 RID: 1601
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/adapters/ScarAdapterFactory", typeof(ScarAdapterFactory));

		// Token: 0x04000642 RID: 1602
		private static Delegate cb_createScarAdapter_Lcom_unity3d_services_ads_gmascar_finder_ScarAdapterVersion_Lcom_unity3d_scar_adapter_common_IAdsErrorHandler_;
	}
}
