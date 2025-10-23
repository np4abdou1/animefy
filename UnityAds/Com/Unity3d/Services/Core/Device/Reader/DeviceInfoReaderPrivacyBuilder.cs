using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200012E RID: 302
	[Register("com/unity3d/services/core/device/reader/DeviceInfoReaderPrivacyBuilder", DoNotGenerateAcw = true)]
	public class DeviceInfoReaderPrivacyBuilder : DeviceInfoReaderBuilder
	{
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0002242C File Offset: 0x0002062C
		internal new static IntPtr class_ref
		{
			get
			{
				return DeviceInfoReaderPrivacyBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00022450 File Offset: 0x00020650
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfoReaderPrivacyBuilder._members;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00022458 File Offset: 0x00020658
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfoReaderPrivacyBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0002247C File Offset: 0x0002067C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfoReaderPrivacyBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00022488 File Offset: 0x00020688
		protected DeviceInfoReaderPrivacyBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00022494 File Offset: 0x00020694
		[Register(".ctor", "(Lcom/unity3d/services/core/configuration/ConfigurationReader;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;Lcom/unity3d/services/core/device/reader/IGameSessionIdReader;)V", "")]
		public unsafe DeviceInfoReaderPrivacyBuilder(ConfigurationReader configurationReader, PrivacyConfigStorage privacyConfigStorage, IGameSessionIdReader gameSessionIdReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configurationReader == null) ? IntPtr.Zero : configurationReader.Handle);
				ptr[1] = new JniArgumentValue((privacyConfigStorage == null) ? IntPtr.Zero : privacyConfigStorage.Handle);
				ptr[2] = new JniArgumentValue((gameSessionIdReader == null) ? IntPtr.Zero : ((Java.Lang.Object)gameSessionIdReader).Handle);
				base.SetHandle(DeviceInfoReaderPrivacyBuilder._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/configuration/ConfigurationReader;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;Lcom/unity3d/services/core/device/reader/IGameSessionIdReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceInfoReaderPrivacyBuilder._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/configuration/ConfigurationReader;Lcom/unity3d/services/core/configuration/PrivacyConfigStorage;Lcom/unity3d/services/core/device/reader/IGameSessionIdReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(configurationReader);
				GC.KeepAlive(privacyConfigStorage);
				GC.KeepAlive(gameSessionIdReader);
			}
		}

		// Token: 0x040002BE RID: 702
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/DeviceInfoReaderPrivacyBuilder", typeof(DeviceInfoReaderPrivacyBuilder));
	}
}
