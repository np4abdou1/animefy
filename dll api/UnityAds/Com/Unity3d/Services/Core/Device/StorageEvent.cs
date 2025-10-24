using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x02000123 RID: 291
	[Register("com/unity3d/services/core/device/StorageEvent", DoNotGenerateAcw = true)]
	public sealed class StorageEvent : Java.Lang.Enum
	{
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00020C34 File Offset: 0x0001EE34
		[Register("CLEAR")]
		public static StorageEvent Clear
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageEvent>(StorageEvent._members.StaticFields.GetObjectValue("CLEAR.Lcom/unity3d/services/core/device/StorageEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x00020C64 File Offset: 0x0001EE64
		[Register("DELETE")]
		public static StorageEvent Delete
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageEvent>(StorageEvent._members.StaticFields.GetObjectValue("DELETE.Lcom/unity3d/services/core/device/StorageEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00020C94 File Offset: 0x0001EE94
		[Register("INIT")]
		public static StorageEvent Init
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageEvent>(StorageEvent._members.StaticFields.GetObjectValue("INIT.Lcom/unity3d/services/core/device/StorageEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x00020CC4 File Offset: 0x0001EEC4
		[Register("READ")]
		public static StorageEvent Read
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageEvent>(StorageEvent._members.StaticFields.GetObjectValue("READ.Lcom/unity3d/services/core/device/StorageEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00020CF4 File Offset: 0x0001EEF4
		[Register("SET")]
		public static StorageEvent Set
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageEvent>(StorageEvent._members.StaticFields.GetObjectValue("SET.Lcom/unity3d/services/core/device/StorageEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00020D24 File Offset: 0x0001EF24
		[Register("WRITE")]
		public static StorageEvent Write
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageEvent>(StorageEvent._members.StaticFields.GetObjectValue("WRITE.Lcom/unity3d/services/core/device/StorageEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00020D54 File Offset: 0x0001EF54
		internal static IntPtr class_ref
		{
			get
			{
				return StorageEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x00020D78 File Offset: 0x0001EF78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StorageEvent._members;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00020D80 File Offset: 0x0001EF80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StorageEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00020DA4 File Offset: 0x0001EFA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StorageEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0000256C File Offset: 0x0000076C
		internal StorageEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00020DB0 File Offset: 0x0001EFB0
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/device/StorageEvent;", "")]
		public unsafe static StorageEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			StorageEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<StorageEvent>(StorageEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/device/StorageEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00020E1C File Offset: 0x0001F01C
		[Register("values", "()[Lcom/unity3d/services/core/device/StorageEvent;", "")]
		public static StorageEvent[] Values()
		{
			return (StorageEvent[])JNIEnv.GetArray(StorageEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/device/StorageEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(StorageEvent));
		}

		// Token: 0x040002A8 RID: 680
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/StorageEvent", typeof(StorageEvent));
	}
}
