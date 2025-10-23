using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Cache
{
	// Token: 0x0200017E RID: 382
	[Register("com/unity3d/services/core/cache/CacheEvent", DoNotGenerateAcw = true)]
	public sealed class CacheEvent : Java.Lang.Enum
	{
		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0002E2B4 File Offset: 0x0002C4B4
		[Register("DOWNLOAD_END")]
		public static CacheEvent DownloadEnd
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheEvent>(CacheEvent._members.StaticFields.GetObjectValue("DOWNLOAD_END.Lcom/unity3d/services/core/cache/CacheEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0002E2E4 File Offset: 0x0002C4E4
		[Register("DOWNLOAD_ERROR")]
		public static CacheEvent DownloadError
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheEvent>(CacheEvent._members.StaticFields.GetObjectValue("DOWNLOAD_ERROR.Lcom/unity3d/services/core/cache/CacheEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0002E314 File Offset: 0x0002C514
		[Register("DOWNLOAD_PROGRESS")]
		public static CacheEvent DownloadProgress
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheEvent>(CacheEvent._members.StaticFields.GetObjectValue("DOWNLOAD_PROGRESS.Lcom/unity3d/services/core/cache/CacheEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0002E344 File Offset: 0x0002C544
		[Register("DOWNLOAD_STARTED")]
		public static CacheEvent DownloadStarted
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheEvent>(CacheEvent._members.StaticFields.GetObjectValue("DOWNLOAD_STARTED.Lcom/unity3d/services/core/cache/CacheEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0002E374 File Offset: 0x0002C574
		[Register("DOWNLOAD_STOPPED")]
		public static CacheEvent DownloadStopped
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheEvent>(CacheEvent._members.StaticFields.GetObjectValue("DOWNLOAD_STOPPED.Lcom/unity3d/services/core/cache/CacheEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x0002E3A4 File Offset: 0x0002C5A4
		internal static IntPtr class_ref
		{
			get
			{
				return CacheEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CacheEvent._members;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0002E3D0 File Offset: 0x0002C5D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CacheEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0002E3F4 File Offset: 0x0002C5F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CacheEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0000256C File Offset: 0x0000076C
		internal CacheEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0002E400 File Offset: 0x0002C600
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/cache/CacheEvent;", "")]
		public unsafe static CacheEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			CacheEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CacheEvent>(CacheEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/cache/CacheEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0002E46C File Offset: 0x0002C66C
		[Register("values", "()[Lcom/unity3d/services/core/cache/CacheEvent;", "")]
		public static CacheEvent[] Values()
		{
			return (CacheEvent[])JNIEnv.GetArray(CacheEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/cache/CacheEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(CacheEvent));
		}

		// Token: 0x0400043F RID: 1087
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/cache/CacheEvent", typeof(CacheEvent));
	}
}
