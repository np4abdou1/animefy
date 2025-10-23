using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Cache
{
	// Token: 0x0200017C RID: 380
	[Register("com/unity3d/services/core/cache/CacheDirectoryType", DoNotGenerateAcw = true)]
	public sealed class CacheDirectoryType : Java.Lang.Enum
	{
		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x0002DCDC File Offset: 0x0002BEDC
		[Register("EXTERNAL")]
		public static CacheDirectoryType External
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheDirectoryType>(CacheDirectoryType._members.StaticFields.GetObjectValue("EXTERNAL.Lcom/unity3d/services/core/cache/CacheDirectoryType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x0002DD0C File Offset: 0x0002BF0C
		[Register("INTERNAL")]
		public static CacheDirectoryType Internal
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheDirectoryType>(CacheDirectoryType._members.StaticFields.GetObjectValue("INTERNAL.Lcom/unity3d/services/core/cache/CacheDirectoryType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0002DD3C File Offset: 0x0002BF3C
		internal static IntPtr class_ref
		{
			get
			{
				return CacheDirectoryType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0002DD60 File Offset: 0x0002BF60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CacheDirectoryType._members;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0002DD68 File Offset: 0x0002BF68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CacheDirectoryType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0002DD8C File Offset: 0x0002BF8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CacheDirectoryType._members.ManagedPeerType;
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0000256C File Offset: 0x0000076C
		internal CacheDirectoryType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0002DD98 File Offset: 0x0002BF98
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/cache/CacheDirectoryType;", "")]
		public unsafe static CacheDirectoryType ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			CacheDirectoryType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CacheDirectoryType>(CacheDirectoryType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/cache/CacheDirectoryType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0002DE04 File Offset: 0x0002C004
		[Register("values", "()[Lcom/unity3d/services/core/cache/CacheDirectoryType;", "")]
		public static CacheDirectoryType[] Values()
		{
			return (CacheDirectoryType[])JNIEnv.GetArray(CacheDirectoryType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/cache/CacheDirectoryType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(CacheDirectoryType));
		}

		// Token: 0x0400043D RID: 1085
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/cache/CacheDirectoryType", typeof(CacheDirectoryType));
	}
}
