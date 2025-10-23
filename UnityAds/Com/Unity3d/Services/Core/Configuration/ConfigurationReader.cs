using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000151 RID: 337
	[Register("com/unity3d/services/core/configuration/ConfigurationReader", DoNotGenerateAcw = true)]
	public class ConfigurationReader : Java.Lang.Object
	{
		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00026D74 File Offset: 0x00024F74
		internal static IntPtr class_ref
		{
			get
			{
				return ConfigurationReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00026D98 File Offset: 0x00024F98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConfigurationReader._members;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00026DA0 File Offset: 0x00024FA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConfigurationReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x00026DC4 File Offset: 0x00024FC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConfigurationReader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ConfigurationReader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00026DD0 File Offset: 0x00024FD0
		[Register(".ctor", "()V", "")]
		public ConfigurationReader() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ConfigurationReader._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ConfigurationReader._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00026E3E File Offset: 0x0002503E
		private static Delegate GetGetCurrentConfigurationHandler()
		{
			if (ConfigurationReader.cb_getCurrentConfiguration == null)
			{
				ConfigurationReader.cb_getCurrentConfiguration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ConfigurationReader.n_GetCurrentConfiguration));
			}
			return ConfigurationReader.cb_getCurrentConfiguration;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00026E62 File Offset: 0x00025062
		private static IntPtr n_GetCurrentConfiguration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ConfigurationReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentConfiguration);
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00026E78 File Offset: 0x00025078
		public virtual Configuration CurrentConfiguration
		{
			[Register("getCurrentConfiguration", "()Lcom/unity3d/services/core/configuration/Configuration;", "GetGetCurrentConfigurationHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Configuration>(ConfigurationReader._members.InstanceMethods.InvokeVirtualObjectMethod("getCurrentConfiguration.()Lcom/unity3d/services/core/configuration/Configuration;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400033F RID: 831
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ConfigurationReader", typeof(ConfigurationReader));

		// Token: 0x04000340 RID: 832
		private static Delegate cb_getCurrentConfiguration;
	}
}
