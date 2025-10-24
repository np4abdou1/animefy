using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200014F RID: 335
	[Register("com/unity3d/services/core/configuration/ConfigurationFailure", DoNotGenerateAcw = true)]
	public sealed class ConfigurationFailure : Java.Lang.Enum
	{
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x000269AC File Offset: 0x00024BAC
		[Register("INVALID_DATA")]
		public static ConfigurationFailure InvalidData
		{
			get
			{
				return Java.Lang.Object.GetObject<ConfigurationFailure>(ConfigurationFailure._members.StaticFields.GetObjectValue("INVALID_DATA.Lcom/unity3d/services/core/configuration/ConfigurationFailure;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x000269DC File Offset: 0x00024BDC
		[Register("NETWORK_FAILURE")]
		public static ConfigurationFailure NetworkFailure
		{
			get
			{
				return Java.Lang.Object.GetObject<ConfigurationFailure>(ConfigurationFailure._members.StaticFields.GetObjectValue("NETWORK_FAILURE.Lcom/unity3d/services/core/configuration/ConfigurationFailure;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00026A0C File Offset: 0x00024C0C
		internal static IntPtr class_ref
		{
			get
			{
				return ConfigurationFailure._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00026A30 File Offset: 0x00024C30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConfigurationFailure._members;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00026A38 File Offset: 0x00024C38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConfigurationFailure._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00026A5C File Offset: 0x00024C5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConfigurationFailure._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0000256C File Offset: 0x0000076C
		internal ConfigurationFailure(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00026A68 File Offset: 0x00024C68
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/ConfigurationFailure;", "")]
		public unsafe static ConfigurationFailure ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ConfigurationFailure @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ConfigurationFailure>(ConfigurationFailure._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/ConfigurationFailure;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00026AD4 File Offset: 0x00024CD4
		[Register("values", "()[Lcom/unity3d/services/core/configuration/ConfigurationFailure;", "")]
		public static ConfigurationFailure[] Values()
		{
			return (ConfigurationFailure[])JNIEnv.GetArray(ConfigurationFailure._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/configuration/ConfigurationFailure;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ConfigurationFailure));
		}

		// Token: 0x0400033B RID: 827
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ConfigurationFailure", typeof(ConfigurationFailure));
	}
}
