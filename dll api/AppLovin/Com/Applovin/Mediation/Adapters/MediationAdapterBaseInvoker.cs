using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapters
{
	// Token: 0x020000F4 RID: 244
	[Register("com/applovin/mediation/adapters/MediationAdapterBase", DoNotGenerateAcw = true)]
	internal class MediationAdapterBaseInvoker : MediationAdapterBase
	{
		// Token: 0x06000A3D RID: 2621 RVA: 0x00019DE0 File Offset: 0x00017FE0
		public MediationAdapterBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0001B988 File Offset: 0x00019B88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediationAdapterBaseInvoker._members;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0001B98F File Offset: 0x00019B8F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediationAdapterBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0001B99C File Offset: 0x00019B9C
		public override string AdapterVersion
		{
			[Register("getAdapterVersion", "()Ljava/lang/String;", "GetGetAdapterVersionHandler")]
			get
			{
				return JNIEnv.GetString(MediationAdapterBaseInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAdapterVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0001B9D0 File Offset: 0x00019BD0
		public override string SdkVersion
		{
			[Register("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get
			{
				return JNIEnv.GetString(MediationAdapterBaseInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSdkVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0001BA04 File Offset: 0x00019C04
		[Register("initialize", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterInitializationParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/MaxAdapter$OnCompletionListener;)V", "GetInitialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_Handler")]
		public unsafe override void Initialize(IMaxAdapterInitializationParameters p0, Activity p1, IMaxAdapterOnCompletionListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				MediationAdapterBaseInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("initialize.(Lcom/applovin/mediation/adapter/parameters/MaxAdapterInitializationParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/MaxAdapter$OnCompletionListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0001BAC4 File Offset: 0x00019CC4
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public override void OnDestroy()
		{
			MediationAdapterBaseInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x04000361 RID: 865
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapters/MediationAdapterBase", typeof(MediationAdapterBaseInvoker));
	}
}
