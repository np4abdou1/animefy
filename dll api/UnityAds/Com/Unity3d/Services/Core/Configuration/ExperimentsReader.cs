using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200015C RID: 348
	[Register("com/unity3d/services/core/configuration/ExperimentsReader", DoNotGenerateAcw = true)]
	public class ExperimentsReader : Java.Lang.Object
	{
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x000292D8 File Offset: 0x000274D8
		internal static IntPtr class_ref
		{
			get
			{
				return ExperimentsReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x000292FC File Offset: 0x000274FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExperimentsReader._members;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00029304 File Offset: 0x00027504
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExperimentsReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00029328 File Offset: 0x00027528
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExperimentsReader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ExperimentsReader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00029334 File Offset: 0x00027534
		[Register(".ctor", "()V", "")]
		public ExperimentsReader() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ExperimentsReader._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ExperimentsReader._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000293A2 File Offset: 0x000275A2
		private static Delegate GetGetCurrentlyActiveExperimentsHandler()
		{
			if (ExperimentsReader.cb_getCurrentlyActiveExperiments == null)
			{
				ExperimentsReader.cb_getCurrentlyActiveExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExperimentsReader.n_GetCurrentlyActiveExperiments));
			}
			return ExperimentsReader.cb_getCurrentlyActiveExperiments;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000293C6 File Offset: 0x000275C6
		private static IntPtr n_GetCurrentlyActiveExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ExperimentsReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentlyActiveExperiments);
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x000293DC File Offset: 0x000275DC
		public virtual IExperiments CurrentlyActiveExperiments
		{
			[Register("getCurrentlyActiveExperiments", "()Lcom/unity3d/services/core/configuration/IExperiments;", "GetGetCurrentlyActiveExperimentsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IExperiments>(ExperimentsReader._members.InstanceMethods.InvokeVirtualObjectMethod("getCurrentlyActiveExperiments.()Lcom/unity3d/services/core/configuration/IExperiments;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0002940E File Offset: 0x0002760E
		private static Delegate GetUpdateLocalExperiments_Lcom_unity3d_services_core_configuration_IExperiments_Handler()
		{
			if (ExperimentsReader.cb_updateLocalExperiments_Lcom_unity3d_services_core_configuration_IExperiments_ == null)
			{
				ExperimentsReader.cb_updateLocalExperiments_Lcom_unity3d_services_core_configuration_IExperiments_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ExperimentsReader.n_UpdateLocalExperiments_Lcom_unity3d_services_core_configuration_IExperiments_));
			}
			return ExperimentsReader.cb_updateLocalExperiments_Lcom_unity3d_services_core_configuration_IExperiments_;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00029434 File Offset: 0x00027634
		private static void n_UpdateLocalExperiments_Lcom_unity3d_services_core_configuration_IExperiments_(IntPtr jnienv, IntPtr native__this, IntPtr native_localExperiments)
		{
			ExperimentsReader @object = Java.Lang.Object.GetObject<ExperimentsReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IExperiments object2 = Java.Lang.Object.GetObject<IExperiments>(native_localExperiments, JniHandleOwnership.DoNotTransfer);
			@object.UpdateLocalExperiments(object2);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00029458 File Offset: 0x00027658
		[Register("updateLocalExperiments", "(Lcom/unity3d/services/core/configuration/IExperiments;)V", "GetUpdateLocalExperiments_Lcom_unity3d_services_core_configuration_IExperiments_Handler")]
		public unsafe virtual void UpdateLocalExperiments(IExperiments localExperiments)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((localExperiments == null) ? IntPtr.Zero : ((Java.Lang.Object)localExperiments).Handle);
				ExperimentsReader._members.InstanceMethods.InvokeVirtualVoidMethod("updateLocalExperiments.(Lcom/unity3d/services/core/configuration/IExperiments;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(localExperiments);
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000294C0 File Offset: 0x000276C0
		private static Delegate GetUpdateRemoteExperiments_Lcom_unity3d_services_core_configuration_IExperiments_Handler()
		{
			if (ExperimentsReader.cb_updateRemoteExperiments_Lcom_unity3d_services_core_configuration_IExperiments_ == null)
			{
				ExperimentsReader.cb_updateRemoteExperiments_Lcom_unity3d_services_core_configuration_IExperiments_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ExperimentsReader.n_UpdateRemoteExperiments_Lcom_unity3d_services_core_configuration_IExperiments_));
			}
			return ExperimentsReader.cb_updateRemoteExperiments_Lcom_unity3d_services_core_configuration_IExperiments_;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000294E4 File Offset: 0x000276E4
		private static void n_UpdateRemoteExperiments_Lcom_unity3d_services_core_configuration_IExperiments_(IntPtr jnienv, IntPtr native__this, IntPtr native_remoteExperiments)
		{
			ExperimentsReader @object = Java.Lang.Object.GetObject<ExperimentsReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IExperiments object2 = Java.Lang.Object.GetObject<IExperiments>(native_remoteExperiments, JniHandleOwnership.DoNotTransfer);
			@object.UpdateRemoteExperiments(object2);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00029508 File Offset: 0x00027708
		[Register("updateRemoteExperiments", "(Lcom/unity3d/services/core/configuration/IExperiments;)V", "GetUpdateRemoteExperiments_Lcom_unity3d_services_core_configuration_IExperiments_Handler")]
		public unsafe virtual void UpdateRemoteExperiments(IExperiments remoteExperiments)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((remoteExperiments == null) ? IntPtr.Zero : ((Java.Lang.Object)remoteExperiments).Handle);
				ExperimentsReader._members.InstanceMethods.InvokeVirtualVoidMethod("updateRemoteExperiments.(Lcom/unity3d/services/core/configuration/IExperiments;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(remoteExperiments);
			}
		}

		// Token: 0x04000385 RID: 901
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ExperimentsReader", typeof(ExperimentsReader));

		// Token: 0x04000386 RID: 902
		private static Delegate cb_getCurrentlyActiveExperiments;

		// Token: 0x04000387 RID: 903
		private static Delegate cb_updateLocalExperiments_Lcom_unity3d_services_core_configuration_IExperiments_;

		// Token: 0x04000388 RID: 904
		private static Delegate cb_updateRemoteExperiments_Lcom_unity3d_services_core_configuration_IExperiments_;
	}
}
